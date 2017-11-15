using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxAirlines.Services;
using FoxAirlines.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxAirlines.Controllers
{
    [Route("")]
    public class StoreController : Controller
    {
        private FoxAirlinesService foxAirlinesService;

        public StoreController(FoxAirlinesService foxAirlinesService) 
            => this.foxAirlinesService = foxAirlinesService;

        public IActionResult Summary() 
            => View(new ViewModels.FlightTicketsOverview(foxAirlinesService.FlightTickets));

        [HttpGet]
        [Route("/new")]
        public IActionResult BuyTicketForm() 
            => View(new FlightTicket());

        [HttpPost]
        [Route("/new")]
        public IActionResult BuyTicketConfirmation(FlightTicket flightTicket)
        {
            if (ModelState.IsValid)
            {
                foxAirlinesService.AddNewFlightTicket(flightTicket);
                return View(flightTicket);
            }
            return View("BuyTicketForm", flightTicket);
        }
    }
}
