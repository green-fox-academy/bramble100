using Ex1ListingTodos.Entities;
using Ex1ListingTodos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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

        internal void Add(IFormCollection formCollection)
        {
            Todo todo = new Todo();
            todo.Title = formCollection["title"];

            todoContext.Add(todo);

            todoContext.SaveChanges();
        }

        internal void Remove(IFormCollection formCollection)
        {
            ;
        }
    }
}
