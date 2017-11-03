using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes2.Entities;

namespace Recipes2.ViewModels
{
    public class Recipes
    {
        public RecipeContext recipeContext;
        public CommentContext commentContext;

        public Recipes()
        {
        }

        public Recipes(RecipeContext recipeContext, CommentContext commentContext)
        {
            this.recipeContext = recipeContext;
            this.commentContext = commentContext;
        }
    }
}
