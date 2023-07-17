using HospitialManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HospitialManagementSystem.Pages.Authentication
{
    public class LoginModel : PageModel
    {
        private SWD_ProjectContext _context = new SWD_ProjectContext();

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            User u = _context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
            if(u != null)
            {
                var options = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore,
                };
                string json = JsonConvert.SerializeObject(u, options);
                HttpContext.Session.SetString("user", json);
                return RedirectToPage("/index");
            }
            return Page();
        }
        public async Task<IActionResult> OnGetLogoutAsync()
        {
            HttpContext.Session.Remove("user");
            return RedirectToPage("../Index");
        }
    }
}
