using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoxAirlines.Models
{
    public class FlightTicket
    {
        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public FlightTicket()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public FlightTicket(string destination, DateTime takeOffDate)
        {
            Destination = destination;
            TakeOffDate = takeOffDate.Date;
        }

        /// <summary>
        /// Ticket ID.
        /// </summary>
        [Key]
        public int Id { get; private set; }

        /// <summary>
        /// The airport to where flight travels.
        /// </summary>
        [Required]
        public string Destination { get; set; }

        /// <summary>
        /// The date on which the plane takes off.
        /// </summary>
        public DateTime TakeOffDate { get; set; }
    }
}
