using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;

namespace MusicApp.DataAccess.Repositories
{
    public class PlaylistEntityRepository : IRepository<Playlist>
    {
        public List<Playlist> GetAll()
        {
            throw new NotImplementedException();
        }

        public Playlist GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Playlist entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Playlist entity)
        {
            throw new NotImplementedException();
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
