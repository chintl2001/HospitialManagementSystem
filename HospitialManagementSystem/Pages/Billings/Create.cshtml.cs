using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HospitialManagementSystem.Models;

namespace HospitialManagementSystem.Pages.Billings
{
    public class CreateModel : PageModel
    {
        private readonly HospitialManagementSystem.Models.SWD_ProjectContext _context;

        public CreateModel(HospitialManagementSystem.Models.SWD_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MedicineId"] = new SelectList(_context.Medicines, "Id", "Id");
        ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "PatientId");
        ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Bill Bill { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Bills == null || Bill == null)
            {
                return Page();
            }

            _context.Bills.Add(Bill);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
