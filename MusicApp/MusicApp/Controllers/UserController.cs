using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Models;
using MusicApp.Models;
using MusicApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            List<User> allUsers = _userService.GetAllUsers();
            List<UserViewModel> viewUsers = new List<UserViewModel>();
            foreach (User user in allUsers)
            {
                UserViewModel mappedUser = new UserViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                };
                viewUsers.Add(mappedUser);
            }

            return View(viewUsers);

        }
        public IActionResult Details(int id)
        {
            User user = _userService.GetUserById(id);
            UserViewModel viewUser = new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Address = user.Address,
                Mail = user.Mail,
                Phone = user.Phone,
                Type = user.Type,
                Price = user.Price
            };
            return View(viewUser);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _userService.AddNewUser(user);
            return RedirectToAction("Inndex");
        }
        public IActionResult Edit(int id)
        {
            User user = _userService.GetUserById(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            _userService.UpdateExistingUser(user);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            User user = _userService.GetUserById(id);
            UserViewModel deleteUser = new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Address = user.Address,
                Mail = user.Mail,
                Phone = user.Phone,
                Type = user.Type,
                Price = user.Price
            };
            return View(deleteUser);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _userService.DeleteUserById(id);
            return RedirectToAction("Index");
        }
    }
}
