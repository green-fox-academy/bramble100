using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice02.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice02.Controllers
{
    public class HomeController : Controller
    {
        LoginData loginData;
        ChosenGame chosenGame;

        public HomeController(LoginData loginData,
            ChosenGame chosenGame)
        {
            this.loginData = loginData;
            this.chosenGame = chosenGame;
        }

        [Route("")]
        public IActionResult Index()
        {
            return RedirectToAction("login");
        }

        [Route("/login")]
        public IActionResult Login() => View();

        [Route("/gameselector")]
        [HttpPost]
        public IActionResult GameSelectorForm(IFormCollection formCollection)
        {
            loginData.UserName = formCollection["Name"];
            loginData.Password = formCollection["Password"];
            return View(loginData);
        }
    }
}
