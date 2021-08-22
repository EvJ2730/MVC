using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{
    public interface IMusicService
    {
        public int AddSong (Song entity);
        public string GetLastName ();
        public List<Song> GetAllSongs ();
        public Song  GetSongById(int id);
        public void UpdateSong(Song song);
        public void DeleteSongById(int id);
    }
}
