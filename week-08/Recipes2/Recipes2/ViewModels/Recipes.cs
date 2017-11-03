using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes2.Entities;

namespace Recipes2.ViewModels
{
    public class Recipes
    {
        private RecipeContext recipeContext;
        private CommentContext commentContext;

        public Recipes(RecipeContext recipeContext, CommentContext commentContext)
        {
            this.recipeContext = recipeContext;
            this.commentContext = commentContext;
        }
    }
}
