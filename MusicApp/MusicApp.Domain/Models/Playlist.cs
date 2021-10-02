using System.Collections.Generic;

namespace MusicApp.Domain.Models
{
    public class Playlist : BaseEntity
    {
        public string Name { get; set; }
        public List<PlaylistItem>   PlaylistItems { get; set; }
    }
}
