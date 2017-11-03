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

        public void Add(Recipe recipe)
        {
            RecipeContext.Add(recipe);
            RecipeContext.SaveChanges();
        }

        public void Edit(Recipe inputRecipe)
        {
            RecipeContext.Update(inputRecipe);
            RecipeContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var recipe = RecipeContext.Recipes.Where(r => r.Id == id).FirstOrDefault();
            RecipeContext.Remove(recipe);
            RecipeContext.SaveChanges();
        }

        internal void Vote(string direction, int id)
        {
            throw new NotImplementedException();
        }
    }
}
