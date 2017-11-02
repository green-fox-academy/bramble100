using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes2.Entities;
using Recipes2.Models;

namespace Recipes2.Repositories
{
    public class RecipeRepository
    {
        public RecipeContext RecipeContext { get; set; }

        public RecipeRepository(RecipeContext recipeContext) => RecipeContext = recipeContext;

        internal void Add(Recipe recipe)
        {
            RecipeContext.Add(recipe);
            RecipeContext.SaveChanges();
        }
    }
}
