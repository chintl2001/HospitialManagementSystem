using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Status
    {
        public Status()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string? Status1 { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
