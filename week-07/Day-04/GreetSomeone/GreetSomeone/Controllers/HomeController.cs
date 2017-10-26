using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        UserData userData;

        public HomeController(UserData userData)
        {
            this.userData = userData;
        }

        [HttpGet]
        [Route("")]
        public IActionResult IndexWithForm()
        {
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Index(string name)
        {
            userData.Name = name;
            return RedirectToAction("ShowData");
        }

        [HttpGet]
        [Route("submit")]
        public IActionResult ShowData()
        {
            return View(userData);
        }

        //[HttpGet]
        //[Route("greet")]
        //public IActionResult Index2()
        //{
        //    return View();
        //}
    }
}
