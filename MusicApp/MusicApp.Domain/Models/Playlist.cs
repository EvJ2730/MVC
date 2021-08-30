using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Domain.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Song { get; set; }
        public DateTime CreatedOn { get; set; }
        
    }
}
