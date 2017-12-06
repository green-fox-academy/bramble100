using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoNet2.Repositories;
using TodoNet2.Models;
using TodoNet2.Interfaces;

namespace TodoNet2.Controllers
{
    [Route("")]
    public class RESTController : Controller
    {
        ITodoRepository TodoRepository;

        public RESTController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("/list")]
        [HttpGet]
        public IActionResult List()
        {
            return Json(TodoRepository.GetList());
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string title)
        {
            TodoRepository.AddTodo(title);
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            TodoRepository.Delete(id);
            return RedirectToAction("List");
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var todo = TodoRepository.Updating(id);
            return Json(todo);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(Todo todo)
        {
            TodoRepository.UpdateTodo(todo);
            return RedirectToAction("List");
        }
    }
}
