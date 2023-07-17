using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Medicine
    {
        public Medicine()
        {
            Bills = new HashSet<Bill>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int? Price { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
