using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{
    public interface IPlaylistService
    {
        public int CreateNewPlaylist(Playlist playlist);
        public Playlist GetPlaylistById(int id);
        public void UpdatePlaylist(Playlist entity);
        public void DeletePlaylistById(int id);
    }
}
