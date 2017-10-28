using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice02.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice02.Controllers
{
    public class GameController : Controller
    {

        LoginData loginData;
        ChosenGame chosenGame;

        public GameController(LoginData loginData,
            ChosenGame chosenGame)
        {
            this.loginData = loginData;
            this.chosenGame = chosenGame;
        }

        [Route("stg")]
        [HttpPost]
        public IActionResult StartBlackJack(IFormCollection formCollection)
        {
            Dictionary<string, ChoosableGame> formProcess = new Dictionary<string, ChoosableGame>()
            {
                { "blackjack", ChoosableGame.BlackJack },
                { "twentyone", ChoosableGame.TwentyOne },
                { "poker", ChoosableGame.Poker },
                { "chess", ChoosableGame.Chess }
            };

            chosenGame.Type = formProcess[formCollection["selectedgame"]];
            return RedirectToAction("PlayBlackJack");
        }

        [Route("ptg")]
        //[HttpPost]
        public IActionResult PlayBlackJack(IFormCollection formCollection)
        {
            return View(loginData);
        }
    }
}
