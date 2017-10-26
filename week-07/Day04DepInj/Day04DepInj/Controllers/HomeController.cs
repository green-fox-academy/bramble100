using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day04DepInj.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day04DepInj.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        Counter counter;

        public HomeController(Counter counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(counter);
        }


        [HttpPost]
        public IActionResult Increase()
        {
            counter.counter++;
            return RedirectToAction("Index");
        }
    }
}
