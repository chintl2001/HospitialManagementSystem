using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            Products = new HashSet<Product>();
        }

        public int InventoryId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
