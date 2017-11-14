using System;
using System.Linq;
using FoxAirlines.Repositories;
using FoxAirlines.Models;
using FoxAirlines.Collections;
using System.Collections.Generic;

namespace FoxAirlines.Services
{
    public class FoxAirlinesService
    {
        private FoxAirlinesRepository foxAirlinesRepository;
        private Random random = new Random();
        private int MinimumNumberOfTickets = 50;
        private int MaximumNumberOfSeatsOnPlane = 12;

        public FoxAirlinesService(FoxAirlinesRepository foxAirlinesRepository)
        {
            this.foxAirlinesRepository = foxAirlinesRepository;
        }

        private bool ContainsExpired
            => foxAirlinesRepository
            .FlightTickets
            .Any(ticket => ticket.TakeOffDate.Date < DateTime.Now.Date);

        private bool NeedGenerateMoreFlightTickets
            => foxAirlinesRepository.FlightTickets.Count() < MinimumNumberOfTickets;

        public HashSet<FlightTicket> FlightTickets 
            => foxAirlinesRepository.FlightTickets;

        public bool ThereIsFreeSeat(DateTime date, string destination)
            => foxAirlinesRepository.FlightTickets.Count(
                ticket => ticket.Destination == destination 
                && ticket.TakeOffDate == date)
            < MaximumNumberOfSeatsOnPlane;

        public void AddNewFlightTicket(FlightTicket flightTicket)
        {
            foxAirlinesRepository.AddNewFlightTicket(flightTicket.TakeOffDate, flightTicket.Destination);
        }

        public void AddNewFlightTicket(DateTime date, string destination)
            => foxAirlinesRepository.AddNewFlightTicket(date, destination);

        public void DeleteExpiredFlightsTickets()
        {
            while (ContainsExpired)
            {
                foxAirlinesRepository.RemoveFlightTicket(
                    foxAirlinesRepository.FlightTickets.FirstOrDefault(
                        ticket => ticket.TakeOffDate < DateTime.Now));
            }
        }

        public void GenerateMoreFlightTickets()
        {
            while (NeedGenerateMoreFlightTickets)
            {
                var takeOffDateTime = DateTime.Now.AddDays(random.Next(7));
                var takeOffDate = new DateTime(
                    takeOffDateTime.Year,
                    takeOffDateTime.Month,
                    takeOffDateTime.Day);
                var destination = Airports.Names.ElementAt(random.Next(Airports.Names.Count));

                if (foxAirlinesRepository.FlightTickets.Count(
                    ticket => ticket.Destination == destination && ticket.TakeOffDate == takeOffDate)
                    < MaximumNumberOfSeatsOnPlane)
                {
                    foxAirlinesRepository.FlightTickets.Add(new FlightTicket(destination, takeOffDate));
                }
            }
        }


    }
}
