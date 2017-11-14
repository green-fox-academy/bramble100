using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxAirlines.Entities;
using System.Collections;

namespace FoxAirlines.ViewModels
{
    public class FlightTicketsOverview
    {
        public HashSet<FlightTicketsOverviewLine> Lines { get; set; } = new HashSet<FlightTicketsOverviewLine>();

        public FlightTicketsOverview(FlightTicketContext flightTicketContext)
        {
            var tickets = flightTicketContext
                .FlightTickets
                .OrderBy(t => t.Destination)
                .OrderBy(t => t.TakeOffDate);

            foreach (var ticket in tickets)
            {
                if(!Lines.Any(line => line.TakeOffDate.Date == ticket.TakeOffDate.Date && line.Destination == ticket.Destination))
                {
                    Lines.Add(new FlightTicketsOverviewLine()
                    {
                        TakeOffDate = ticket.TakeOffDate.Date,
                        Destination = ticket.Destination
                    });
                }
            }

            foreach (var line in Lines)
            {
                line.NumberOfFreeSeats = tickets.Count(t => line.TakeOffDate.Date == t.TakeOffDate.Date && line.Destination == t.Destination);
            }
        }
    }

    public class FlightTicketsOverviewLine
    {
        public DateTime TakeOffDate { get; set; }
        public string Destination { get; set; }
        public int NumberOfFreeSeats { get; set; }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
        public class FlightTicketsOverviewLineEqualityComparer : IEqualityComparer<FlightTicketsOverviewLine>
        {
            public bool Equals(FlightTicketsOverviewLine x, FlightTicketsOverviewLine y)
            {
                if (x == null && y == null)
                    return true;
                else if (x == null | y == null)
                    return false;
                else if (x.TakeOffDate == y.TakeOffDate && x.Destination == y.Destination)
                    return true;

                return false;
            }

            public int GetHashCode(FlightTicketsOverviewLine obj) 
                => $"{obj.TakeOffDate}{obj.Destination}".GetHashCode();
        }
    }

}
