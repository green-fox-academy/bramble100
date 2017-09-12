using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortablePokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            string hand1 = "KS 2h 5C JD TD";
            try
            {
                PokerHand hand = new PokerHand(hand1);
                Console.WriteLine(hand.HandIsValid(hand1));
            }
            catch (ArgumentException e){
                Console.WriteLine(e.Message);
            }
        }
    }

    public class PokerHand
    {
        char[] Ranks = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
        char[] Suits = { 'S', 'H', 'D', 'C' };
        char Separator = ' ';
        string[] Hand = new string[5];

        public PokerHand(string hand)
        {
            if (!HandIsValid(hand))
            {
                throw new ArgumentException("Invalid poker hand string");
            }
        }

        public bool HandIsValid(string hand)
        {
            foreach (char c in hand.ToUpper())
            {
                if (!(Ranks.Contains(c) || Suits.Contains(c) || c == Separator))
                {
                    return false;
                }
            }

            HashSet<string> handStrings = new HashSet<string>();
            foreach (string card in hand.Split(Separator))
            {
                if (!(card.Length == 2) || !(Ranks.Contains(card[0]) || Suits.Contains(card[1])))
                {
                    return false;
                }
                handStrings.Add(card);
            }
            return handStrings.Count == 5;
            //return true;
        }
    }
}
