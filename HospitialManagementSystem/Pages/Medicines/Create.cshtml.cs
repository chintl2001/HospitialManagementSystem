using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HospitialManagementSystem.Models;

namespace HospitialManagementSystem.Pages.Medicines
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
            return Page();
        }

        [BindProperty]
        public Medicine Medicine { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            _context.Medicines.Add(Medicine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
