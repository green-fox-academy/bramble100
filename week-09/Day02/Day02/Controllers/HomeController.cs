using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day02.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input== null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("greeter")]
        public IActionResult Greeter( DTO input)
        {
            if (String.IsNullOrEmpty(input.name))
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (String.IsNullOrEmpty(input.title))
            {
                return Json(new { error = "Please provide a title!" });
            }

            return Json(new { welcome_message = $"Oh, hi there {input.name}, my dear {input.title}!" });
        }

        public class DTO
        {
            public string name { get; set; }
            public string title { get; set; }
        }
    }
}
