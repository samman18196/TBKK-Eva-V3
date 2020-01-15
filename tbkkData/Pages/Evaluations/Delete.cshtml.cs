using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Evaluations
{
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Evaluation Evaluation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Evaluation = await _context.Evaluation.FirstOrDefaultAsync(m => m.EvaluationID == id);

            if (Evaluation == null)
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

            Evaluation = await _context.Evaluation.FindAsync(id);

            if (Evaluation != null)
            {
                _context.Evaluation.Remove(Evaluation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
