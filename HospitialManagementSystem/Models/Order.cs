using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string? State { get; set; }
        public int? StatusId { get; set; }
        public int OrderDetailsId { get; set; }

        public virtual OrderDetail OrderDetails { get; set; } = null!;
        public virtual OrderStatus? Status { get; set; }
    }
}
