using System.Collections.Generic;
using TodoNet2.Models;

namespace TodoNet2.Interfaces
{
    public interface ITodoRepository
    {
        List<Todo> GetList();
        List<Todo> NotDone();
        void AddTodo(string title);
        void Delete(int id);
        Todo Updating(int id);
        void UpdateTodo(Todo todo);    
    }
}
