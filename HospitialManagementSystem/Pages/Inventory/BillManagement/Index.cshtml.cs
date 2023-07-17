using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitialManagementSystem.Models;

namespace HospitialManagementSystem.Pages.Inventory.BillManagement
{
    public class IndexModel : PageModel
    {
        private readonly HospitialManagementSystem.Models.SWD_ProjectContext _context;

        public IndexModel(HospitialManagementSystem.Models.SWD_ProjectContext context)
        {
            _context = context;
        }

        public IList<Bill> Bill { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Bills != null)
            {
                Bill = await _context.Bills
                .Include(b => b.Medicine)
                .Include(b => b.Patient)
                .Include(b => b.Status).ToListAsync();
            }
        }
    }
}
