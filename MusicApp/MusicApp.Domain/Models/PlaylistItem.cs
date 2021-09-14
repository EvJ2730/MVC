namespace MusicApp.Domain.Models
{
    public class PlaylistItem : BaseEntity
    {
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
    }
}
