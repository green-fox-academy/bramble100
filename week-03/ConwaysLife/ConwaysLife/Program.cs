using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Conway's Game of Life - Unlimited Edition
// https://www.codewars.com/kata/conways-game-of-life-unlimited-edition/train/csharp

namespace ConwaysLife
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Universe Universe = new Universe();
            Universe.Display();
            Console.WriteLine("Press ESC to exit, any other key to refresh.");
            key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                Universe.Update();
                Universe.Display();
                Console.WriteLine("Press ESC to exit, any other key to refresh.");
                key = Console.ReadKey();
            }
        }
    }
}
