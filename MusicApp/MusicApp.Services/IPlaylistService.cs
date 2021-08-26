using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{
    public interface IPlaylistService
    {
        public int MakeNewPlaylist(Playlist entity);
        public int AddNewSong(Song entity);
        public List<Song> GetLastSong();
        public List<Playlist> GetAllSongs(Song entity);
        public void DeleteSongById(int id);
    }
}
