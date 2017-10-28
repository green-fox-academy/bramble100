using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        private Fox fox;

        public HomeController(Fox fox)
        {
            this.fox = fox;
        }

        [Route("/")]
        [Route("/info")]
        public IActionResult Index()
        {
            return View(fox);
        }
    }
}
