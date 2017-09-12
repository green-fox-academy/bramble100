﻿using System;
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
            string textMessage = "12 90, 3,,,; 44 2";
            List<long> gameType = new List<long> { 5, 90 };

            Console.WriteLine("SMS Lottery Bet Validator");
            Console.WriteLine("The user has to guess {0} numbers out of {1}.", gameType[0], gameType[1]);
            Console.WriteLine("The user input for this game type is: " + textMessage);
            Console.WriteLine("The text message for this game type is {0}.", TextMessageIsValid(textMessage) ? "valid" : "invalid");

            SortedSet<long> userInput = ProcessedUserInput(textMessage);
            Console.WriteLine("The user input for this game type is {0}.", BetIsValid(gameType, userInput) ? "valid" : "invalid");

            if (BetIsValid(gameType, userInput))
            {
                Console.WriteLine("The cleaned and sorted user input is:");
                foreach(long bet in userInput)
                {
                    Console.Write("{0} ", bet);
                }
            }
            Console.ReadKey();
        }

        static bool TextMessageIsValid(string userInput)
        {
            return true;
        }
        static SortedSet<long> ProcessedUserInput(string userInput)
        {
            SortedSet<long> returnList = new SortedSet<long>();
            foreach (string segment in userInput.Split(' ', ','))
            {
                if (Int64.TryParse(segment, out long result))
                {
                    returnList.Add(result);
                }
            }
            return returnList;
        }

        static bool BetIsValid(List<long> gameType, SortedSet<long> bet) => (bet.Count == gameType[0] && bet.Max <= gameType[1]);
    }
}