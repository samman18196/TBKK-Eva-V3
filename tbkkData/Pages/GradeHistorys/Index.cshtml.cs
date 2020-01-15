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
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }


        public IList<Position> Position { get; set; }

        public Employee Employee { get; set; }

        public IList<GradeHistory> GradeHistory { get;set; }

        public GradeHistory GradeHistoryI { get; set; }

        public Evaluation Evaluation{ get; set; }




        public async Task<IActionResult> OnGetAsync(int? id)
        {
            GradeHistory = await _context.GradeHistory
                .ToListAsync();

            Position = await _context.Position
                .ToListAsync();

            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Evaluation.Add(Evaluation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
