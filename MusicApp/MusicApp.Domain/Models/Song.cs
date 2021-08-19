using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Domain.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public decimal Duration { get; set; }

        public DateTime Date = new DateTime();
    }
}
