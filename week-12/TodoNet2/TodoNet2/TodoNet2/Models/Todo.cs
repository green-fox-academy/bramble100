using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoNet2.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; } = false;
        public bool IsDone { get; set; } = false;
    }
}
