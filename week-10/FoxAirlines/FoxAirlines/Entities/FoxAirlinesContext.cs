using FoxAirlines.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxAirlines.Entities
{
    public class FlightTicketContext : DbContext
    {
        public DbSet<FlightTicket> FlightTickets { get; set; }
        private int MinimumNumberOfTickets = 50;
        private int MaximumNumberOfSeatsOnPlane = 50;
        Random random = new Random();

        public FlightTicketContext(DbContextOptions<FlightTicketContext> dbContextOptions, Random random) : base(dbContextOptions)
        {
            this.random = random;
        }

        public FlightTicketContext(DbContextOptions<FlightTicketContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public bool ThereIsFreeSeat(DateTime date, string destination)
        {
            return FlightTickets.Count(
                    ticket => ticket.Destination == destination && ticket.TakeOffDate == date)
                    < MaximumNumberOfSeatsOnPlane;
        }

        public void AddNewFlightTicket(DateTime date, string destination)
        {
            if (date.Date >= DateTime.Now.Date
                && date != null
                && !String.IsNullOrEmpty(destination))
            {
                Add(new FlightTicket()
                {
                    TakeOffDate = date,
                    Destination = destination
                });
                SaveChanges();
            }
        }

        private bool NeedGenerateMore => FlightTickets.Count() < MinimumNumberOfTickets;
        private bool ContainsExpired => FlightTickets.Any(ticket => ticket.TakeOffDate < DateTime.Now);

        public void DeleteExpiredFlights()
        {
            while (ContainsExpired)
            {
                Remove(FlightTickets.FirstOrDefault(t => t.TakeOffDate < DateTime.Now));
                SaveChanges();
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

                if (FlightTickets.Count(
                    ticket => ticket.Destination == destination && ticket.TakeOffDate == takeOffDate)
                    < MaximumNumberOfSeatsOnPlane)
                {
                    FlightTickets.Add(new FlightTicket(destination, takeOffDate));
                }
            }
            SaveChanges();
        }
    }
}