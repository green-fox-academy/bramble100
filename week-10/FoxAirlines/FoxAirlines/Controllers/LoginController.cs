using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxAirlines.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxAirlines.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult LoginForm()
        {
            return View(new User());
        }

        [Route("login"), HttpPost]
        public IActionResult LoginResult(User user)
        {
            if(Collections.GitHubHandlesAlpaga.Contains(user.LoginName))
            {
                return View("WelcomeFirst", user);
            }
            return View("UnsuccessfulLogin");
        }
    }
}
