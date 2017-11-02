using Recipes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Models;

namespace Recipes.Repositories
{
    public class RecipeRepository
    {
        /// <summary>
        /// The recipe context for the repository.
        /// </summary>
        public RecipeContext RecipeContext { get; set; }
        /// <summary>
        /// Constructor for the repository with dependency injection.
        /// </summary>
        /// <param name="recipeContext"></param>
        public RecipeRepository(RecipeContext recipeContext) => this.RecipeContext = recipeContext;

        internal void Add(Recipe recipe)
        {
            if (recipe!=null)
            {
                RecipeContext.Add(recipe);
                RecipeContext.SaveChanges();
            }
        }
    }
}
