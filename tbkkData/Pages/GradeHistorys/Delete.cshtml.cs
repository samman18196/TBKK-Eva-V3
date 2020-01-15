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
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GradeHistory GradeHistory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GradeHistory = await _context.GradeHistory.FirstOrDefaultAsync(m => m.GradeHistoryID == id);

            if (GradeHistory == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GradeHistory = await _context.GradeHistory.FindAsync(id);

            if (GradeHistory != null)
            {
                _context.GradeHistory.Remove(GradeHistory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
