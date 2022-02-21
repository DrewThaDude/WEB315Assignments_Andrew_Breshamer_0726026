using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesChess.Models
{
    public class Chess
    {
        public int ID { get; set; }
        public int quardLetter { get; set; } 
        public int quardNumber { get; set; } 
        public bool inCheck { get; set; }
        public bool colour { get; set; }
    }
}