
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LagopusExam.Controllers
{
    [Route("")]
    public class APIController : Controller
    {
        [HttpGet]
        [Route("questions")]
        public IActionResult Questions()
        {
            return Json(new { });
        }
    }
}
