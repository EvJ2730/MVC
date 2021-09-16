using System.Collections.Generic;

namespace MusicApp.Domain.Models
{
    public class Playlist : BaseEntity
    {
        public User User { get; set; }
        public string Name { get; set; }
        public List<PlaylistItem> Songs { get; set; }
    }
}
