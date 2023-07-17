using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitialManagementSystem.Models;

namespace HospitialManagementSystem.Pages.Medicines
{
    public class IndexModel : PageModel
    {
        private readonly HospitialManagementSystem.Models.SWD_ProjectContext _context;

        public IndexModel(HospitialManagementSystem.Models.SWD_ProjectContext context)
        {
            _context = context;
        }
        public string CurrentFilter { get; set; }
        public IList<Medicine> Medicine { get;set; } = default!;

        public async Task OnGetAsync(string searchString)
        {
            if (_context.Medicines != null)
            {
                var qr = from a in _context.Medicines select a;
                Medicine = await _context.Medicines.ToListAsync();

                //search
                if (!String.IsNullOrEmpty(searchString))
                {
                    Medicine = qr.Where(s => s.Name.Contains(searchString) || s.Description.Contains(searchString)).ToList();
                }
                //
            }
        }
    }
}
