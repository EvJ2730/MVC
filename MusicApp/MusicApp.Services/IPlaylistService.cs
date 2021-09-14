using MusicApp.Domain.Models;
using System.Collections.Generic;

namespace MusicApp.Services
{
    public interface IPlaylistService
    {
        public int MakeNewPlaylist(int id);
        //public List<Song> AddNewSong(Song entity);
        //public List<Song> GetLastSong();
        public List<Playlist> GetAllSongs(Song entity);
        public void DeleteSongById(int id);
        public void DeletePlaylistById(int id);
    }
}
