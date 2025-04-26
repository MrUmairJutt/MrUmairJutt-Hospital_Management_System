using Microsoft.AspNetCore.Mvc;
using HospitalManagement.Data;
using HospitalManagement.Models;
using System.Linq;

namespace HospitalManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly NeondbContext _context;
        public HomeController(NeondbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                DoctorCount = _context.Doctors.Count(),
                PatientCount = _context.Patients.Count(),
                AppointmentCount = _context.Appointments.Count(),
                DepartmentCount = _context.Departments.Count(),
                PrescriptionCount = _context.Prescriptions.Count(),
                RecentAppointments = (from a in _context.Appointments
                                     join d in _context.Doctors on a.DoctorId equals d.Id
                                     join p in _context.Patients on a.PatientId equals p.Id
                                     orderby a.Date descending
                                     select new DashboardAppointmentViewModel
                                     {
                                         AppointmentId = a.Id,
                                         DoctorName = d.Name,
                                         PatientName = p.Name,
                                         Date = a.Date
                                     }).Take(10).ToList()
            };
            return View(model);
        }
    }
}
