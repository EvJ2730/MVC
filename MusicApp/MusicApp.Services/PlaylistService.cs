using MusicApp.DataAccess;
using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicApp.Services
{
    public class PlaylistService : IPlaylistService
    {
        private IRepository<Playlist> _playlistRepository;

        public PlaylistService(IRepository<Playlist> playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }

        public int MakeNewPlaylist(Playlist entity)
        {
            return _playlistRepository.Insert(entity);
        }

        ////problem IPlaylistService
        //public int AddNewSong(Song entity)
        //{
        //    return _playlistRepository.Insert(entity);
        //}

        public List<Playlist> GetAllSongs(Song entity)
        {
            return _playlistRepository.GetAll();
        }

        //public List<Song> GetLastSong()
        //{
        //    return _playlistRepository.GetAll();
        //}

        public void DeleteSongById(int id)
        {
            _playlistRepository.DeleteById(id);
        }

        public int MakeNewPlaylist(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePlaylistById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
