using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public int? InventoryId { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Inventory? Inventory { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
