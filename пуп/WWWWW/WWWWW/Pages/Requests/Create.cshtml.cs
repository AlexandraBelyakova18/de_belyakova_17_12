using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WWWWW.Data;
using WWWWW.models;

namespace WWWWW.Pages.Requests
{
    public class CreateModel : PageModel
    {
        private readonly WWWWW.Data.WWWWWContext _context;

        public CreateModel(WWWWW.Data.WWWWWContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Request Request { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Request.Add(Request);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
