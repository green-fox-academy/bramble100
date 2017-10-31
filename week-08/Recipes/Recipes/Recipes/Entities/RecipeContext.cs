using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes.Entities
{
    public class RecipeContext : DbContext
    {
        /// <summary>
        /// The actual recipes collections.
        /// </summary>
        private DbSet<Recipe> recipes;
        /// <summary>
        /// Getter method for recipe collection.
        /// </summary>
        public DbSet<Recipe> Recipes => recipes;
        /// <summary>
        /// Constructor for context object.
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public RecipeContext(DbContextOptions<RecipeContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}
