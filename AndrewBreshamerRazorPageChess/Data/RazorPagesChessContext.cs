using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesChess.Models;

    public class RazorPagesChessContext : DbContext
    {
        public RazorPagesChessContext (DbContextOptions<RazorPagesChessContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesChess.Models.Chess> Chess { get; set; }
    }
