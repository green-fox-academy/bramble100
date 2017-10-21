using System;

namespace Zoo
{
    public class Mammal :Animal
    {
        public Mammal(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine("Hi, I'm a mammal.");
        }

        public override void Move()
        {
            Console.WriteLine("I'm crawling."); ;
        }

        public override string UtterSound()
        {
            return "Woof, meow (whatever you want from a mammal).";
        }

        public override string WantChild()
        {
            return "want a child from my uterus!";
        }
    }
}
