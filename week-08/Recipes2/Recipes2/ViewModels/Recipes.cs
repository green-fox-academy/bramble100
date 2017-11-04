using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes2.Entities;
using Recipes2.Models;

namespace Recipes2.ViewModels
{
    public class Recipes
    {
        public RecipeContext recipeContext;
        public CommentContext commentContext;
        public int Count => Lines.Count;
        public List<RecipeLine> Lines { get; set; } = new List<RecipeLine>();
        Random random = new Random();

        public Recipes(RecipeContext recipeContext, CommentContext commentContext)
        {
            this.recipeContext = recipeContext;
            this.commentContext = commentContext;

            foreach (var recipe in recipeContext.Recipes.OrderBy(r => -r.Votes))
            {
                Lines.Add(new RecipeLine()
                {
                    Recipe = recipe,
                    NumberOfComments = commentContext.Comments.Where(c => c.RecipeId == recipe.Id).Count()
                    //NumberOfComments = random.Next(5)
                });
            }
        }

        public class RecipeLine
        {
            public Recipe Recipe;
            public int NumberOfComments;

            public bool ThereAreComments => NumberOfComments != 0;
        }
    }
}
