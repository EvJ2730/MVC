using MusicApp.DataAccess;
using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public int AddNewUser(User entity)
        {
            //validation
            return _userRepository.Insert(entity);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public string GetLastUsername()
        {
            return _userRepository.GetAll().FirstOrDefault().Username;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void UpdateExistingUser(User user)
        {
            //validation
            _userRepository.Update(user);
        }

        public void DeleteUserById(int id)
        {
            _userRepository.DeleteById(id);
        }
    }
}
