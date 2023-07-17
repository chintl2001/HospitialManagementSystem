using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Bills = new HashSet<Bill>();
        }

        public int PatientId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Dob { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
