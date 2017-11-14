﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxAirlines.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxAirlines.Controllers
{
    [Route("")]
    public class StoreController : Controller
    {
        private FlightTicketRepository flightTicketRepository;

        public StoreController(FlightTicketRepository flightTicketRepository)
        {
            this.flightTicketRepository = flightTicketRepository;
        }

        public IActionResult Summary()
        {
            return View(new ViewModels.FlightTicketsOverview(flightTicketRepository.flightTicketContext));
        }
    }
}
