using MusicApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Domain.Models
{
    public class Account  
    {
        public string Standard { get; set; }
        public string Student { get; set; } 
        public string Premium { get; set; }
        public string Family { get; set; }

    }
}
