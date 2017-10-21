using System;

namespace Zoo
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine("Hi, I'm a bird.");
        }

        public override void Move()
        {
            Console.WriteLine("I'm flying, or something."); ;
        }

        public override string UtterSound()
        {
            return "Chirp, chirp.";
        }

        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}