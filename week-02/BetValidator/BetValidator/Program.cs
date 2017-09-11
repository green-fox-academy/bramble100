using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/sms-lottery-bet-validator

namespace BetValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string textMessage = "12 90 3 44 2";
            List<long> gameType = new List<long> { 5, 90 };

            Console.WriteLine("The user input for this game type is: " + textMessage);

            SortedSet<long> userInput = ProcessedUserInput(textMessage);
            Console.WriteLine("The user input for this game type is {0}.", BetIsValid(gameType, userInput) ? "valid" : "invalid");

            if (BetIsValid(gameType, userInput))
            {
                foreach(long bet in userInput)
                {
                    Console.WriteLine(bet);
                }
                
            }
            

            Console.ReadKey();
        }

        static SortedSet<long> ProcessedUserInput(string userInput)
        {
            SortedSet<long> returnList = new SortedSet<long>();
            foreach (string segment in userInput.Split(' ', ','))
            {
                returnList.Add(Int64.Parse(segment));
            }
            return returnList;
        }

        static bool BetIsValid(List<long> gameType, SortedSet<long> bet)
        {
            return (bet.Count == gameType[0] && bet.Max <= gameType[1]);
        }
    }
}
