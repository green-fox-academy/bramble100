using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamora.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
