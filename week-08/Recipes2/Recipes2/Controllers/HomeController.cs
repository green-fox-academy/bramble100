using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes2.Repositories;
using Microsoft.AspNetCore.Http;
using Recipes2.Models;
using Recipes2.ViewModels;

namespace Recipes2.Controllers
{
    public class HomeController : Controller
    {
        private RecipeRepository recipeRepository;

        public HomeController(RecipeRepository recipeRepository) => this.recipeRepository = recipeRepository;

        [Route("")]
        [Route("/list")]
        public IActionResult Index()
        {
            return View(recipeRepository.RecipeContext.Recipes);
        }

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

        [Route("/edit/{id}")]
        [HttpGet]
        public IActionResult ModifyForm(int id) => View(recipeRepository.RecipeContext.Recipes.Find(id));

        [Route("/edit")]
        [HttpPost]
        public IActionResult ModifyConfirmation(IFormCollection formCollection)
        {
            if (String.IsNullOrEmpty(formCollection["recipename"]))
            {
                return View("Error");
            }

            var recipe = new Recipe()
            {
                Name = formCollection["recipename"],
                Id = Convert.ToInt32(formCollection["id"])
            };
            recipeRepository.Edit(recipe);
            return View(recipe);
        }

        [Route("/delete/{id}")]
        [HttpGet]
        public IActionResult DeleteConfirmation(int id)
        {
            var recipe = recipeRepository
                .RecipeContext
                .Recipes
                .Where(r => r.Id == id)
                .FirstOrDefault();

            recipeRepository.Delete(id);
            return View(recipe);
        }

        [Route("vote/up/{id}")]
        public IActionResult VoteUp(int id)
        {
            recipeRepository.Vote("up", id);
            return RedirectToAction("Index");
        }

        [Route("vote/down/{id}")]
        public IActionResult VoteDown(int id)
        {
            recipeRepository.Vote("down", id);
            return RedirectToAction("Index");
        }

        [Route("/error")]
        public IActionResult Error() => View();
    }
}
