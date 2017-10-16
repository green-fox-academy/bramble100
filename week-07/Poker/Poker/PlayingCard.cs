using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class PlayingCard
    {
        public char Rank { get; }
        public char Suit { get; }
        public bool IsValid  { get; private set; }

        string validRanks = "23456789TJQKA";
        string validSuites = "SHDC";

        public PlayingCard(string inputString)
        {
            IsValid = false;
            if (String.IsNullOrEmpty(inputString) || !validRanks.Contains(inputString[0]))
            {
                return;
            }

            IsValid = inputString.Length == 2;

            Rank = inputString[0];
            Suit = inputString[1];
            IsValid = true;
        }
    }
}
