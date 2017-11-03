using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes2.Models
{
    /// <summary>
    /// Data for one comment regarding a recipe.
    /// </summary>
    public class Comments
    {
        /// <summary>
        /// Primary Key for comment.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Foreign Key for recipe. Registers to which recipe the comment relates.
        /// </summary>
        [Required]
        public int RecipeId { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [Required]
        [MinLength(2)]
        [MaxLength(1000)]
        public string Text { get; set; }

        /// <summary>
        /// The exact date and time when the comment was entered.
        /// </summary>
        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
