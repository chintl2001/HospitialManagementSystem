using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitialManagementSystem.Models;

namespace HospitialManagementSystem.Pages.Authentication.User_Management
{
    public class IndexModel : PageModel
    {
        private readonly HospitialManagementSystem.Models.SWD_ProjectContext _context;

        public IndexModel(HospitialManagementSystem.Models.SWD_ProjectContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users
                .Include(u => u.Role).ToListAsync();
            }
        }
    }
}
