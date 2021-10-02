using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{
    public interface IPlaylistItemService
    {
        public string AddPLaylistItem(PlaylistItem entity);
        public void UpdatePlaylistItem(PlaylistItem entity);
        public void DeleteItemById(int id);
    }
}
