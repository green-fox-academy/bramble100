using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex1ListingTodos.Entities;
using Ex1ListingTodos.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex1ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("")]
        [Route("/list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
