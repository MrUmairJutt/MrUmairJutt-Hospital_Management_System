using System.Collections.Generic;

namespace HospitalManagement.Models
{
    public class DashboardViewModel
    {
        public int DoctorCount { get; set; }
        public int PatientCount { get; set; }
        public int AppointmentCount { get; set; }
        public int DepartmentCount { get; set; }
        public int PrescriptionCount { get; set; }
        public List<DashboardAppointmentViewModel> RecentAppointments { get; set; }
    }
}