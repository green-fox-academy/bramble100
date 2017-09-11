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
            /*HashSet<int> userInput = userInputProcessor(textMessage);*/

            foreach ( long bet in UserInputProcessor(textMessage))
            {
                Console.WriteLine(bet);
            }
            Console.ReadKey();
        }

        static SortedSet<long> UserInputProcessor(string userInput)
        {
            SortedSet<long> returnList = new SortedSet<long>();
            foreach (string segment in userInput.Split(' ', ','))
            {
                returnList.Add(Int64.Parse(segment));
            }
            return returnList;
        }

        static bool BetIsValid(List<int> gameType, SortedSet<long> bet)
        {
            if 
            foreach(long uniqueBetin bet)

        }
    }
}
