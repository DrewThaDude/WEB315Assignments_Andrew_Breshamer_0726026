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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesChessContext _context;

        public DetailsModel(RazorPagesChessContext context)
        {
            _context = context;
        }

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
    }
}
