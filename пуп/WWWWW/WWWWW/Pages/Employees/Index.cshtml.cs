using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WWWWW.Data;
using WWWWW.models;

namespace WWWWW.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly WWWWW.Data.WWWWWContext _context;

        public IndexModel(WWWWW.Data.WWWWWContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
