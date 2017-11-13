using System;
using System.ComponentModel.DataAnnotations;

namespace FoxAirlines.Models
{
    public class User
    {
        [Key, Required, MinLength(2), MaxLength(30)]
        public string LoginName { get; set; }
        [Required, MinLength(6), MaxLength(30)]
        public string Password { get; set; } = "alpaga";
        [Required]
        public DateTime LastAttemptedLogin { get; set; } = DateTime.Now;
        public DateTime LastSuccesfulLogin { get; set; } = DateTime.Now;
    }
}
