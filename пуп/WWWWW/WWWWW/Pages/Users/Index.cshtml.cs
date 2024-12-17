using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WWWWW.Data;
using WWWWW.models;

namespace WWWWW.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly WWWWW.Data.WWWWWContext _context;

        public IndexModel(WWWWW.Data.WWWWWContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
