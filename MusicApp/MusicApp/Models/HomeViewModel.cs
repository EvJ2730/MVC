using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class HomeViewModel
    {
        public List<Song> MySongs { get; set; }
        public List<Playlist> MyPlaylists { get; set; }
    }
}
