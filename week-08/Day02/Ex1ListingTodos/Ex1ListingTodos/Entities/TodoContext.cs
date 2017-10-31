using Ex1ListingTodos.Models;
using Ex1ListingTodos.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1ListingTodos.Entities
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            foreach (var asd in Todos) {
            }
        }
    }
}
