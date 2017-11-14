using FoxAirlines.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FoxAirlines.Entities
{
    public class FoxAirlinesContext : DbContext
    {
        public DbSet<FlightTicket> FlightTickets { get; private set; }

        public FoxAirlinesContext(DbContextOptions<FoxAirlinesContext> dbContextOptions) : base(dbContextOptions)
        {
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

        public FlightTicket FlightTicketById(int id) 
            => FlightTickets.FirstOrDefault(t => t.Id == id);

        public void UpdateFlightTicket(FlightTicket flightTicket)
        {
            FlightTickets.Update(flightTicket);
            SaveChanges();
        }

        public void DeleteFlightTicket(int id)
        {
            var ticket = FlightTickets.Find(id);
            FlightTickets.Remove(ticket);
            SaveChanges();
        }

        internal void DeleteFlightTicket(FlightTicket flightTicket)
        {
            FlightTickets.Remove(flightTicket);
            SaveChanges();
        }
    }
}