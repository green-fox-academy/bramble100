using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex1ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        [Route("")]
        [Route("/list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
