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
    }

    //public class DTO
    //{
    //    public int Received { get; set; }
    //    public int Result => Received * 2;
    //}
}
