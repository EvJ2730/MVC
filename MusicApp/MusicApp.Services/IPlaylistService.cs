using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{
    public interface IPlaylistService
    {
        public int CreateNewPlaylist(Playlist playlist);
        public List<PlaylistItem> GetAllPlaylistItem(PlaylistItem playlistItem);
        public string GetAllPlaylists(Playlist entity);
        public void UpdatePlaylist(Playlist entity);
        public void DeletePlaylistById(int id);
    }
}
