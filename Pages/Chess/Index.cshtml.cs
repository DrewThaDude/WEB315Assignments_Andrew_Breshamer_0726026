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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesChessContext _context;

        public IndexModel(RazorPagesChessContext context)
        {
            _context = context;
        }

        public IList<Chess> Chess { get;set; }

        public async Task OnGetAsync()
        {
            Chess = await _context.Chess.ToListAsync();
        }
    }
}
