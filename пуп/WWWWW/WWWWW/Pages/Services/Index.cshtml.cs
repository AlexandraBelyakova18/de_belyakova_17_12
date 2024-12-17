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
    public class IndexModel : PageModel
    {
        private readonly WWWWW.Data.WWWWWContext _context;

        public IndexModel(WWWWW.Data.WWWWWContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Service = await _context.Service.ToListAsync();
        }
    }
}
