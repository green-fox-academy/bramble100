using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;
using Recipes.Repositories;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipes.Controllers
{
    public class HomeController : Controller
    {
        RecipeRepository recipeRepository;

        public HomeController(RecipeRepository recipeRepository) => this.recipeRepository = recipeRepository;

        [Route("")]
        [Route("/list")]
        [HttpGet]
        public IActionResult Index() => View(recipeRepository.RecipeContext.Recipes);

        [Route("/add")]
        [HttpGet]
        public IActionResult AddForm() => View();

        [Route("/add")]
        [HttpPost]
        public IActionResult AddConfirmation(IFormCollection formCollection)
        {
            var recipe = new Recipe()
            {
                Name = formCollection["recipe"],
            };
            recipeRepository.Add(recipe);
            return View(recipe);
        }

        [Route("/change")]
        //[HttpPost]
        public IActionResult Change(IFormCollection formCollection)
        {
            var command = formCollection.Keys
                .ElementAt(0)
                .ToString()
                .Split('-');
            if (command[0].Equals("edit"))
            {
                return RedirectToRoute($"edit/id={command[1]}");
            }
            else if (command[0].Equals("delete"))
            {
                return RedirectToRoute($"delete/{command[1]}");
            }
            return RedirectToRoute("");
        }

        [Route("/edit/{id}")]
        [HttpGet]
        public IActionResult EditForm(int id)
        {
            return RedirectToRoute("");
        }

        [Route("/delete/{id}")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return RedirectToRoute("");
        }
    }
}
