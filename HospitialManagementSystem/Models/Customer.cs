using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Customer
    {
        public Customer()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gmail { get; set; }
        public string? Adress { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
