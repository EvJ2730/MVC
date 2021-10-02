using MusicApp.DataAccess;
using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{

    class PlaylistItemService : IPlaylistItemService
    {
        private IRepository<PlaylistItem> _playlistItemRepository;
        public PlaylistItemService(IRepository<PlaylistItem> playlistItemRepository)
        {
            _playlistItemRepository = playlistItemRepository;
        }
        public string AddPLaylistItem(PlaylistItem entity)
        {
            return _playlistItemRepository.Insert(entity);
        }

        public void DeleteItemById(int id)
        {
            _playlistItemRepository.DeleteById(id);
        }

        public void UpdatePlaylistItem(PlaylistItem entity)
        {
            _playlistItemRepository.Update(entity);
        }
    }
}
