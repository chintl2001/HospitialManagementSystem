using System;
using System.Collections.Generic;

namespace HospitialManagementSystem.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
    }
}
