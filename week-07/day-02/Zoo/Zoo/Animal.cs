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

        public abstract void Greet();

        public abstract void WantChild();

        public abstract void UtterSound();

        public abstract void Move();
    }
}
