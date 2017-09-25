using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThingsProgram
{
    class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name) => Name = name;

        public Thing(string name, bool completed) : this(name) => Completed = completed;

        public override string ToString() => $"[{(Completed ? "X" : " ")}] {Name}";

        public void Complete() => Completed = true;
    }
}
