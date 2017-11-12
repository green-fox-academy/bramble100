using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login.Models;
using Login.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Login.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private UserRepository userRepository;

        public HomeController(UserRepository userRepository) 
            => this.userRepository = userRepository;

        [HttpGet]
        public IActionResult LoginForm() => View(new User());

        [HttpPost, Route("login")]
        public IActionResult LoginEvaluation(User user)
        {
            if (userRepository.UserExists(user.LoginName))
            {
                return View(user);
            }
            return RedirectToAction("LoginForm");
        }
    }
}
