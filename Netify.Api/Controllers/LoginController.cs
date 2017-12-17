using System;
using Microsoft.AspNetCore.Mvc;
using Netify.Authentication;
using Netify.Models;

namespace Netify.Controllers
{
    [Route("/login")]
    public class LoginController : Controller
    {
        private UserService _userService;

        public LoginController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public void Login(LoginRequest login)
        {
            if (string.IsNullOrWhiteSpace(login.UserName) || string.IsNullOrWhiteSpace(login.Password))
            {
                throw new ArgumentNullException();
            }

            var authenticated = _userService.Authenticate(login.UserName, login.Password);

        }

    }
}
