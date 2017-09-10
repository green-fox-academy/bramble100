using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            Random rnd = new Random();
            int numberToGuess = rnd.Next(1, 65);
            int guess;
            Console.WriteLine("A random number is generated (between 1 and 64)");
            do
            {
                Console.WriteLine("Enter a guess, please:");
                guess = Int32.Parse(Console.ReadLine());

                if (guess > numberToGuess)
                {
                    Console.WriteLine("The stored number is lower.");
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("The stored number is higher.");
                }
            } while (numberToGuess != guess);
            Console.WriteLine("You found the number: " + numberToGuess);

            Console.ReadKey();
        }
    }
}
