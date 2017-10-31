using Ex1ListingTodos.Entities;
using Ex1ListingTodos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1ListingTodos.Repositories
{
    public class TodoRepository
    {
        public TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public void Add()
        {
            todoContext.Todos.Add(new Todo()
            {
                Title = $"Say hello {DateTime.Now.ToString()}",
                IsUrgent = false,
                IsDone = false
            });
            todoContext.SaveChanges();
        }
    }
}
