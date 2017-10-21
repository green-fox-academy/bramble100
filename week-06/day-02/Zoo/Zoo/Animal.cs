using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        public string name;
        public int age;
        public bool isMale;
        public double weight;
        public bool canFly;

        public Animal(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public abstract void Greet();

        public abstract string WantChild();

        public abstract string UtterSound();

        public abstract void Move();
    }
}
