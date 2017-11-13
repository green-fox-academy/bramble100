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
        /// Ticket ID.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The airport from where flight travels.
        /// </summary>
        [Required]
        public string Origin { get; private set; }
        /// <summary>
        /// The airport to where flight travels.
        /// </summary>
        [Required]
        public string Destination { get; private set; }
        /// <summary>
        /// The ID of the buyer.
        /// </summary>
        [Required]
        public int  BuyerId { get; set; }
    }
}
