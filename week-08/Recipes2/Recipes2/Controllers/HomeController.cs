using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes2.Repositories;
using Microsoft.AspNetCore.Http;
using Recipes2.Models;

namespace Recipes2.Controllers
{
    public class HomeController : Controller
    {
        private RecipeRepository recipeRepository;

        public HomeController(RecipeRepository recipeRepository) => this.recipeRepository = recipeRepository;

        [Route("")]
        [Route("/list")]
        public IActionResult Index() => View(recipeRepository.RecipeContext.Recipes);

        [Route("/add")]
        [HttpGet]
        public IActionResult AddForm() => View();

        [Route("/add")]
        [HttpPost]
        public IActionResult AddConfirmation(IFormCollection formCollection)
        {
            if (String.IsNullOrEmpty(formCollection["recipename"]))
            {
                return View("Error");
            }

            var recipe = new Recipe()
            {
                Name = formCollection["recipename"]
            };
            recipeRepository.Add(recipe);
            return View(recipe);
        }

        [Route("/error")]
        public IActionResult Error() => View();
    }
}
