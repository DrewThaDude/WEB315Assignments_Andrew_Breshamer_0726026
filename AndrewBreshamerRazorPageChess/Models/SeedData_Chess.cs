using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace RazorPagesChess.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesChessContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesChessContext>>()))
            {
                //Look for Chess pieces
                if (context.Chess.Any())
                {
                    return;   // DB has been seeded
                }

                context.Chess.AddRange(
                    new Chess
                    {
                        quardLetter = 'A',
                        quardNumber = 4,
                        inCheck = false,
                        colour = false
                    },
                    new Chess
                    {
                        quardLetter = 'D',
                        quardNumber = 7,
                        inCheck = true,
                        colour = false
                    },
                    new Chess
                    {
                        quardLetter = 'H',
                        quardNumber = 2,
                        inCheck = false,
                        colour = false
                    },
                    new Chess
                    {
                        quardLetter = 'E',
                        quardNumber = 8,
                        inCheck = true,
                        colour = true
                    },
                    new Chess
                    {
                        quardLetter = 'C',
                        quardNumber = 3,
                        inCheck = false,
                        colour = false
                    }

                );
                context.SaveChanges();
            }
        }
    }
}