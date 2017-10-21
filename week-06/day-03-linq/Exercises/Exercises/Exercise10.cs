using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise10
    {
        public static void Run()
        {
            // Create a Fox class with 3 properties(name, type, color) Fill a 
            // list with at least 5 foxes, it's up to you how you name/create 
            // them! Write a LINQ Expression to find the foxes with green 
            // color! Write a LINQ Expression to find the foxes with green 
            // color and pallida type!

            Fox[] foxes = new Fox[]
            {
                new Fox("Charlie","corsac", "red"),
                new Fox("India","bengalensis", "purple"),
                new Fox("Arnold","pallida", "green"),
                new Fox("Ohio","pallida", "green"),
                new Fox("Swift","velox", "green")
            };

            WithLinqExpression(foxes);

            WithMethodExpression(foxes);
        }

        private static void WithLinqExpression(Fox[] foxes)
        {
            Console.WriteLine("Linq expression:");
            Console.WriteLine("Green:");

            var query = from fox in foxes
                        where fox.color.Equals("green")
                        select fox;

            query.ToList().ForEach(f => Console.WriteLine(f));

            Console.WriteLine("Green and pallida:");

            query = from fox in foxes
                        where fox.color.Equals("green") && fox.type.Equals("pallida")
                        select fox;

            query.ToList().ForEach(f => Console.WriteLine(f));
        }

        private static void WithMethodExpression(Fox[] foxes)
        {
            Console.WriteLine("Method expression:");

            Console.WriteLine("Green:");

            foxes
                .Where(fox => fox.color.Equals("green"))
                .ToList()
                .ForEach(fox => Console.WriteLine(fox));

            Console.WriteLine("Green and pallida:");

            foxes
                .Where(fox => fox.color.Equals("green") && fox.type.Equals("pallida"))
                .ToList()
                .ForEach(fox => Console.WriteLine(fox));
        }
    }

    public class Fox
    {
        public string name;
        public string type;
        public string color;

        public Fox(string name, string type, string color)
        {
            this.name = name;
            this.type = type;
            this.color = color;
        }

        public override string ToString() 
            => $"Hi, I am {name}, a {color}, {type} type fox.";
    }
}
