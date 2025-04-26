using System;
using System.Collections.Generic;

namespace HospitalManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Medication { get; set; }
    }
}
