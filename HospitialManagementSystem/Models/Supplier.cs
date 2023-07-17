using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Contact { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
