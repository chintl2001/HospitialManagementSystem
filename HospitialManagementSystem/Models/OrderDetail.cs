using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Type { get; set; }
        public DateTime? Date { get; set; }
        public int? CustomerId { get; set; }
        public int? MedicineId { get; set; }
        public int? Quantity { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Medicine? Medicine { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
