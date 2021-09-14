using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;

namespace MusicApp.DataAccess.Repositories
{
    public class SongEntityRepository : IRepository<Song>
    {
        public List<Song> GetAll()
        {
            throw new NotImplementedException();
        }

        public Song GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Song entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Song entity)
        {
            throw new NotImplementedException();
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
