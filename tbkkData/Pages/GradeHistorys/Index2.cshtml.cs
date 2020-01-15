using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.GradeHistorys
{
    public class Index2Model : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public Index2Model(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }
        public IList<Employee> Employee { get; set; }
        public IList<GradeHistory> GradeHistory { get; set; }

        public async Task OnGetAsync()
        {
            GradeHistory = await _context.GradeHistory.ToListAsync();

            Employee = await _context.Employee.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {


            return RedirectToPage("./Index2");
        }
    }
}
