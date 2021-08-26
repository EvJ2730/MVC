using MusicApp.DataAccess;
using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.Services
{
    public class SongService : ISongService
    {
        private IRepository<Song> _songRepository;
        public SongService(IRepository<Song> songRepository)
        {
            _songRepository = songRepository;
        }
        public int AddSong(Song entity)
        {
            return _songRepository.Insert(entity);
        }

        public List<Song> GetAllSongs()
        {
            return _songRepository.GetAll();
        }

        public string GetLastSong()
        {
            return _songRepository.GetAll().FirstOrDefault().Name;
        }

        public Song GetSongById(int id)
        {
            return _songRepository.GetById(id);
        }

        public void UpdateSong(Song song)
        {
            _songRepository.Update(song);
        }

        public void DeleteSongById(int id)
        {
            _songRepository.DeleteById(id);
        }
    }
}
