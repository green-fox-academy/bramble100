using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes2.Entities;
using Recipes2.Models;

namespace Recipes2.Repositories
{
    public class CommentRepository
    {
        public CommentContext CommentContext { get; set; }

        public CommentRepository(CommentContext commentContext) => CommentContext = commentContext;

        public void Add(Comment comment)
        {
            CommentContext.Add(comment);
            CommentContext.SaveChanges();
        }
    }
}
