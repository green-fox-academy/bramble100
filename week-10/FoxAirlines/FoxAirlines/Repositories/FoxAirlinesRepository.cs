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
        private int MinimumNumberOfTickets = 50;
        private int MaximumNumberOfSeatsOnPlane = 12;
        Random random = new Random();

        public HashSet<FlightTicket> FlightTickets 
            => new HashSet<FlightTicket>(foxAirlinesContext.FlightTickets);
       
        private bool ContainsExpired 
            => foxAirlinesContext.FlightTickets.Any(ticket => ticket.TakeOffDate.Date < DateTime.Now.Date);

        public bool NeedGenerateMore 
            => foxAirlinesContext.FlightTickets.Count() < MinimumNumberOfTickets;

        public FoxAirlinesRepository(FoxAirlinesContext flightTicketContext, Random random)
            => this.foxAirlinesContext = flightTicketContext;

        public FoxAirlinesRepository(FoxAirlinesContext foxAirlinesContext)
            => this.foxAirlinesContext = foxAirlinesContext;

        public bool ThereIsFreeSeat(DateTime date, string destination)
            => FlightTickets.Count(
                    ticket => ticket.Destination == destination && ticket.TakeOffDate == date)
                    < MaximumNumberOfSeatsOnPlane;

        public void AddNewFlightTicket(DateTime date, string destination)
            => foxAirlinesContext.AddNewFlightTicket(date, destination);

        public void DeleteExpiredFlights()
        {
            while (ContainsExpired)
            {
                foxAirlinesContext.Remove(
                    foxAirlinesContext.FlightTickets.FirstOrDefault(
                        ticket => ticket.TakeOffDate < DateTime.Now));
            }
        }

        public void GenerateMore()
        {
            while (NeedGenerateMore)
            {
                var takeOffDateTime = DateTime.Now.AddDays(random.Next(7));
                var takeOffDate = new DateTime(
                    takeOffDateTime.Year,
                    takeOffDateTime.Month,
                    takeOffDateTime.Day);
                var destination = Collections.Airports.Names.ElementAt(random.Next(7));

                if (foxAirlinesContext.FlightTickets.Count(
                    ticket => ticket.Destination == destination && ticket.TakeOffDate == takeOffDate)
                    < MaximumNumberOfSeatsOnPlane)
                {
                    foxAirlinesContext.FlightTickets.Add(new FlightTicket(destination, takeOffDate));
                }
            }
            foxAirlinesContext.SaveChanges();
        }
    }
}