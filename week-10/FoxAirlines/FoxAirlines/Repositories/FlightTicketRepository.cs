using FoxAirlines.Entities;
using System;

namespace FoxAirlines.Repositories
{
    public class FlightTicketRepository
    {
        public FlightTicketContext flightTicketContext { get; set; }

        public FlightTicketRepository(FlightTicketContext flightTicketContext, Random random) 
            => this.flightTicketContext = flightTicketContext;

        public bool ThereIsFreeSeat(DateTime date, string destination) 
            => flightTicketContext.ThereIsFreeSeat(date, destination);

        public void AddNewFlightTicket(DateTime date, string destination) 
            => flightTicketContext.AddNewFlightTicket(date, destination);
    }
}