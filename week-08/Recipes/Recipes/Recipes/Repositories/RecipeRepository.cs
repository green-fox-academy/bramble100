using Recipes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Repositories
{
    public class RecipeRepository
    {
        /// <summary>
        /// The entity to the model.
        /// </summary>
        private RecipeContext recipeContext;
        /// <summary>
        /// Constructor for the repository with dependency injection.
        /// </summary>
        /// <param name="recipeContext"></param>
        public RecipeRepository(RecipeContext recipeContext) => this.recipeContext = recipeContext;
    }
}
