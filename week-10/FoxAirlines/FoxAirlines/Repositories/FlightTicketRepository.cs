using FoxAirlines.Entities;
using System;

namespace FoxAirlines.Repositories
{
    public class FlightTicketRepository
    {
        public FlightTicketContext flightTicketContext { get; set; }

        public FlightTicketRepository(FlightTicketContext flightTicketContext, Random random)
        {
            this.flightTicketContext = flightTicketContext;
        }
    }
}