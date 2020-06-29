using BookingRooms.Models;
using BookingRooms.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookingRooms.Controllers
{
    public class UsersController : Controller
    {
        private UserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }

        public IActionResult Index()
        {
            List<UserModel> rooms = _userService.GetAllUsers();
            return View(rooms);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult AddUser(UserModel user)
        {
            _userService.AddUser(user);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult DoLogin(UserModel user)
        {
            bool isValidUser = _userService.DoLogin(user);

            if (!isValidUser)
                return RedirectToAction("Register", "Users");

            return RedirectToAction("Index", "Home");
        }

        public IActionResult EditUserView(string id)
        {
            UserModel user = _userService.FindUserById(id);

            return View("EditUser", user);
        }

        public IActionResult EditUser(UserModel user)
        {
            _userService.EditUser(user);

            return RedirectToAction("Index", "Users");
        }
    }
}
