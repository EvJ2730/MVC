using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.DataAccess
{
    public class UserEntityRepository : IRepository<User>
    {
        public List<User> GetAll()
        {
            return StaticDb.Users.ToList();
        }

        public User GetById(int id)
        {
            return StaticDb.Users.FirstOrDefault(x => x.Id.Equals(id));
        }

        public int Insert(User entity)
        {
            User lastUser = StaticDb.Users.LastOrDefault();
            if (lastUser == null)
            {
                entity.Id = 1;
            }
            else
            {
                entity.Id = lastUser.Id + 1;
            }
            StaticDb.Users.Add(entity);
            return entity.Id;
        }

        public void Update(User entity)
        {
            User user = StaticDb.Users.FirstOrDefault(x=>x.Id.Equals(entity.Id));
            if(user != null)
            {
                user.FirstName = entity.FirstName;
                user.LastName = entity.LastName;
                user.Username = entity.Username;
                user.Address = entity.Address;
                user.Mail = entity.Mail;
                user.Phone = entity.Phone;
                user.Type = entity.Type;
                user.Price = entity.Price;
            }
        }

        public void DeleteById(int id)
        {
            User user = StaticDb.Users.FirstOrDefault(x => x.Id.Equals(id));
            if (user != null)
            {
                StaticDb.Users.Remove(user);
            }
        }
    }
}
