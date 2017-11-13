using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxAirlines.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxAirlines.Controllers
{
    [Route("/airport")]
    public class AirportController : Controller
    {
        private FlightTicketRepository flightTicketRepository;

        public AirportController(FlightTicketRepository flightTicketRepository)
        {
            this.flightTicketRepository = flightTicketRepository;
            this.flightTicketRepository.flightTicketContext.DeleteExpiredFlights();
            this.flightTicketRepository.flightTicketContext.GenerateMore();
            
        }
        [Route("")]
        public IActionResult Index()
        {
            return View(new ViewModels.FlightTicketsOverview(flightTicketRepository.flightTicketContext));
        }
    }
}
