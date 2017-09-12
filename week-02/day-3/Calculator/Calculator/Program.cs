using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Supports the following operations: +, -, *, /, %");
            Console.WriteLine("Supports two operands.");
            Console.WriteLine("Examples: '+ 3 3' (the result will be 6) or '* 4 4' (the result will be 16)");
            Console.Write("Please type in the expression: ");

            Console.WriteLine("The result is: {0}", Calculator(Console.ReadLine()));

            Console.ReadKey();
        }

        private static long Calculator(string v)
        {
            string[] userInputs = v.Split(' ');
            long number1 = Int64.Parse(userInputs[1]);
            long number2 = Int64.Parse(userInputs[2]);

            switch (userInputs[0])
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                case "%":
                    return number1 % number2;
            }
            return 0;
        }
    }
}
