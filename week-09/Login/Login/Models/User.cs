using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Models
{
    public class User
    {
        [Key]
        public string LoginName { get; set; }
        [Required, MinLength(6), MaxLength(30)]
        public string Password { get; set; } = "alpaga";
        [Required]
        public DateTime LastAttemptedLogin { get; set; } = DateTime.Now;
        public DateTime LastSuccesfulLogin { get; set; } = DateTime.Now;
    }
}
