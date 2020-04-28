using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ETMS.Data;
using ETMS_Blazor.Data;

namespace ETMS_Blazor.View.Course
{
    public class IndexModel : PageModel
    {
        private readonly ETMS.Data.EMSContext _context;

        public IndexModel(ETMS.Data.EMSContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
