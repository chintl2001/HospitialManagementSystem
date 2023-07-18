using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitialManagementSystem.Models;

namespace HospitialManagementSystem.Pages.Billings
{
    public class EditModel : PageModel
    {
        private readonly HospitialManagementSystem.Models.SWD_ProjectContext _context;

        public EditModel(HospitialManagementSystem.Models.SWD_ProjectContext context)
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

            var bill =  await _context.Bills.FirstOrDefaultAsync(m => m.Id == id);
            if (bill == null)
            {
                return NotFound();
            }
            Bill = bill;
           ViewData["MedicineId"] = new SelectList(_context.Medicines, "Id", "Id");
           ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientId");
           ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillExists(Bill.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BillExists(int id)
        {
          return (_context.Bills?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
