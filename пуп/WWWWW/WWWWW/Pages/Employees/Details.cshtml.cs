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
    public class DetailsModel : PageModel
    {
        private readonly WWWWW.Data.WWWWWContext _context;

        public DetailsModel(WWWWW.Data.WWWWWContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                Employee = employee;
            }
            return Page();
        }
    }
}
