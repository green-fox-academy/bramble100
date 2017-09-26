using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram
{
    class Animal
    {
        private int hunger = 50;
        private int thirst = 50;

        public void Eat() => hunger -= 1;

        public void Drink() => thirst -= 1;

        public void Play()
        {
            hunger += 1;
            thirst += 1;
        }
    }
}
