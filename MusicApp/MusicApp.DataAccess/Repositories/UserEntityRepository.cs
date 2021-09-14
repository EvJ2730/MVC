using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;

namespace MusicApp.DataAccess.Repositories
{
    public class UserEntityRepository : IRepository<User>
    {
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
