using System.ComponentModel.DataAnnotations;

namespace Recipes2.Models
{
    /// <summary>
    /// Data for one recipe.
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Primary Key for recipe.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The name of the recipe.
        /// </summary>
        [MinLength(2)]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The country from which the recipe originates.
        /// </summary>
        [MinLength(2)]
        [MaxLength(50)]
        public string Cuisine { get; set; }
        /// <summary>
        /// The time in minutes that needed for the preparation (max 5 hours).
        /// </summary>
        [Range(5, 300)]
        public int PreparationTimeInMinutes { get; set; }
        /// <summary>
        /// Shows how hard the recipe is to prepare.
        /// </summary>
        [MinLength(2)]
        [MaxLength(20)]
        public string Level { get; set; }
        /// <summary>
        /// True if the recipe is vegetarian.
        /// </summary>
        [Required]
        public bool IsVegetarian { get; set; } = false;
    }
}
