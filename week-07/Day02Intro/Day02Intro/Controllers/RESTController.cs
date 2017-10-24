using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day02Intro.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day02Intro.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        static int counter = 0;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greeting = new Greeting();
            greeting.Id = ++counter;
            greeting.Content = $"I'm a greeting. And I say: Hello {name}";
            return new JsonResult(greeting);
        }
    }
}
