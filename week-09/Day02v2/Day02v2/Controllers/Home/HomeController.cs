using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day02v2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day02v2.Controllers.Home
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpPost]
        //[Route("arrays/{dto?}")]
        //[Route("arrays")]
        public IActionResult Index(
            [FromBody]
            ArraysDTO dto)
        {
            return Json(new { status = "ok" });
        }
    }
}
