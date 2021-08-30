using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services
{
    public interface IUserService
    {
        public int AddNewUser(User entity);
        public string GetLastUsername();
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        public void UpdateExistingUser(User user);
        public void DeleteUserById(int id); 

    }
}
