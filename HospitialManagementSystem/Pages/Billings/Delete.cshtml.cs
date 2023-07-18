using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitialManagementSystem.Models;

namespace HospitialManagementSystem.Pages.Billings
{
    public class DeleteModel : PageModel
    {
        private readonly HospitialManagementSystem.Models.SWD_ProjectContext _context;

        public DeleteModel(HospitialManagementSystem.Models.SWD_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Bill Bill { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Bills == null)
            {
                return NotFound();
            }

            var bill = await _context.Bills.FirstOrDefaultAsync(m => m.Id == id);

            if (bill == null)
            {
                return NotFound();
            }
            else 
            {
                Bill = bill;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Bills == null)
            {
                return NotFound();
            }
            var bill = await _context.Bills.FindAsync(id);

            if (bill != null)
            {
                Bill = bill;
                _context.Bills.Remove(Bill);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
