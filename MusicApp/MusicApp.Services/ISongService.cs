using MusicApp.Domain.Models;
using System.Collections.Generic;

namespace MusicApp.Services
{
    public interface ISongService
    {
        public int AddSong(Song entity);
        public string GetLastSong();
        public List<Song> GetAllSongs();
        public Song GetSongById(int id);
        public void UpdateSong(Song song);
        public void DeleteSongById(int id);
    }
}
