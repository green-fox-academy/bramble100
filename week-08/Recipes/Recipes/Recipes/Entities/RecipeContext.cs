using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes.Entities
{
    public class RecipeContext : DbContext
    {
        /// <summary>
        /// The recipes collections.
        /// </summary>
        public DbSet<Recipe> Recipes { get; set; }
        /// <summary>
        /// Constructor for context object.
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public RecipeContext(DbContextOptions<RecipeContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}
