using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Profile
{
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }
        public IList<Evaluation> Evaluation  { get; set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();

            Evaluation = await _context.Evaluation.ToListAsync();
        }
        public Department Department { get; set; }
    }
}
