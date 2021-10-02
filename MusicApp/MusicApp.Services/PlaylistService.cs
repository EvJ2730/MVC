using MusicApp.DataAccess;
using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{
    class PlaylistService : IPlaylistService
    {
        private IRepository<Playlist> _playlistRepository;
        public PlaylistService(IRepository<Playlist> playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }

        public int CreateNewPlaylist(Playlist playlist)
        {
            return _playlistRepository.Insert(playlist);
        }

        public List<PlaylistItem> GetAllPlaylistItem()
        {
            return _playlistRepository.GetAll();
        }

        public string GetPlaylistById(int id)
        {
            return _playlistRepository.GetById(id);
        }
        public void UpdatePlaylist(Playlist entity)
        {
            _playlistRepository.Update(entity);
        }

        public void DeletePlaylistById(int id)
        {
            _playlistRepository.DeleteById(id);
        }


    }
}
