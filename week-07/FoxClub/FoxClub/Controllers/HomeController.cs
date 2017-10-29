using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using Microsoft.AspNetCore.Http;
using FoxClub.HelperDictionaries;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        private Fox fox;

        public HomeController(Fox fox)
        {
            this.fox = fox;
        }

        [Route("/")]
        [Route("/information")]
        public IActionResult Information()
        {
            return View(fox);
        }

        [HttpGet]
        [Route("/nutritionstore")]
        public IActionResult NutritionStoreForm()
        {
            return View(new ViewModels.FoodnDrink());
        }

        [HttpPost]
        [Route("/nutritionstore")]
        public IActionResult NutritionStoreConfirmation(IFormCollection formCollection)
        {
            fox.Food = HelperDictionary.StringToFood[formCollection["food"]];
            fox.Drink = HelperDictionary.StringToDrink[formCollection["drink"]];
            return View(fox);
        }

        [HttpGet]
        [Route("/trickcenter")]
        public IActionResult TrickCenterForm()
        {
            return View(fox);
        }

        [HttpPost]
        [Route("/trickcenter")]
        public IActionResult TrickCenterConfirmation(IFormCollection formCollection)
        {
            fox.Tricks.Add(HelperDictionary.StringToTrick[formCollection["trick"]]);
            return View(fox);
        }

        [HttpGet]
        [Route("/actionhistory")]
        public IActionResult ActionHistory()
        {
            return View(fox);
        }
    }
}
