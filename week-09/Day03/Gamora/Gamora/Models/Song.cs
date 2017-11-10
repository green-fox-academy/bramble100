using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamora.Models
{
    /// <summary>
    /// CLass to hold a song's data.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// ID, Primary key
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Author(s) of the song
        /// </summary>
        [Required]
        public string Author { get; set; }
        /// <summary>
        /// Title of the song
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// Genre of the song
        /// </summary>
        [Required]
        public string Genre { get; set; }
        /// <summary>
        /// Release date of the song
        /// </summary>
        [Required]
        public int Year { get; set; } = DateTime.Now.Year;
        /// <summary>
        /// Rating of the song (1...5)
        /// </summary>
        public int Rating { get; set; } = 3;
        /// <summary>
        /// Internal flag, if true, the song is considered as deleted (soft delete).
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
