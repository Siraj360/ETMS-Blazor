using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ETMS.Data;
using ETMS_Blazor.Data;

namespace ETMS_Blazor.View.Employer
{
    public class IndexModel : PageModel
    {
        private readonly ETMS.Data.EMSContext _context;

        public IndexModel(ETMS.Data.EMSContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
