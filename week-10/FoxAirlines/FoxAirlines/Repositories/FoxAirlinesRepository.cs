using FoxAirlines.Entities;
using FoxAirlines.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoxAirlines.Repositories
{
    public class FoxAirlinesRepository
    {
        private FoxAirlinesContext foxAirlinesContext;

        public HashSet<FlightTicket> FlightTickets 
            => new HashSet<FlightTicket>(foxAirlinesContext.FlightTickets);
       
        public FoxAirlinesRepository(FoxAirlinesContext foxAirlinesContext)
            => this.foxAirlinesContext = foxAirlinesContext;

        public void AddNewFlightTicket(DateTime date, string destination)
            => foxAirlinesContext.AddNewFlightTicket(date, destination);

        public void RemoveFlightTicket(FlightTicket flightTicket) 
            => foxAirlinesContext.DeleteFlightTicket(flightTicket);
    }
}