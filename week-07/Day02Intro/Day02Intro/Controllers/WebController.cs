using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day02Intro.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day02Intro.Controllers
{
    public class WebController : Controller
    {
        static int counter = 0;

        [Route("web")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                Id = ++counter,
                Content = name
            };

            return View(greeting);
        }
    }
}
