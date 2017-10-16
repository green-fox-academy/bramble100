using System;

namespace Zoo
{
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine("Hi, I'm a reptile.");
        }

        public override void Move()
        {
            Console.WriteLine("I'm crawling."); ;
        }

        public override string UtterSound()
        {
            return "Hsss, hsss (yo, I might be a crocodile).";
        }

        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}