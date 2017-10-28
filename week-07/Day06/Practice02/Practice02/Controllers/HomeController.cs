using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice02.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return RedirectToAction("login");
        }

        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/gameselector")]
        public IActionResult GameSelector()
        {
            return View();
        }

        [Route("/blackjack")]
        public IActionResult BlackJack()
        {
            return View();
        }
    }
}
