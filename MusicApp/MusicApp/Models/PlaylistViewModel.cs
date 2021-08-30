using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class PlaylistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Song { get; set; }
        public DateTime Date { get; set; }
    }
}
