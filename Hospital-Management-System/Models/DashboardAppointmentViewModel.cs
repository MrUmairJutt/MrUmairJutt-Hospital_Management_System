namespace HospitalManagement.Models
{
    public class DashboardAppointmentViewModel
    {
        public int AppointmentId { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
    }
}