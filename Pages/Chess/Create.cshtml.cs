using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesChess.Models;

namespace RazorPagesChess.Pages_Chess
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesChessContext _context;

        public CreateModel(RazorPagesChessContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Chess Chess { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Chess.Add(Chess);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
