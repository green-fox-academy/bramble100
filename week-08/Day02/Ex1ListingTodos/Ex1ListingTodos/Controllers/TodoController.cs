using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex1ListingTodos.Entities;
using Ex1ListingTodos.Repositories;
using Ex1ListingTodos.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex1ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository) => this.todoRepository = todoRepository;

        [Route("/listone")]
        public IActionResult ListOne()
        {
            return View(todoRepository.todoContext.Todos.Last());
        }

        [Route("")]
        [Route("/list")]
        public IActionResult List() => View(todoRepository.todoContext.Todos);

        [Route("/add")]
        public IActionResult Add()
        {
            todoRepository.Add();
            return RedirectToAction("List");
        }
    }
}
