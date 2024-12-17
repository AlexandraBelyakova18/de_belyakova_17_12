using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WWWWW.Data;
using WWWWW.models;

namespace WWWWW.Pages.Services
{
    public class DetailsModel : PageModel
    {
        private readonly WWWWW.Data.WWWWWContext _context;

        public DetailsModel(WWWWW.Data.WWWWWContext context)
        {
            _context = context;
        }

        public Service Service { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service.FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }
            else
            {
                Service = service;
            }
            return Page();
        }
    }
}
