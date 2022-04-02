using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesChess.Models;

namespace RazorPagesChess.Pages_Chess
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesChessContext _context;

        public DeleteModel(RazorPagesChessContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Chess Chess { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chess = await _context.Chess.FirstOrDefaultAsync(m => m.ID == id);

            if (Chess == null)
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

            Chess = await _context.Chess.FindAsync(id);

            if (Chess != null)
            {
                _context.Chess.Remove(Chess);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
