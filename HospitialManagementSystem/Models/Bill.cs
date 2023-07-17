using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Bill
    {
        public int Id { get; set; }
        public int? StatusId { get; set; }
        public int? Staffid { get; set; }
        public int? MedicineId { get; set; }
        public int? Quantiy { get; set; }
        public string? Supplier { get; set; }
        public double? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PatientId { get; set; }

        public virtual Medicine? Medicine { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Status? Status { get; set; }
    }
}
