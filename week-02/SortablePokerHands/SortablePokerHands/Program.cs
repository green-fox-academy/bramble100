using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortablePokerHands
{

    // https://www.codewars.com/kata/sortable-poker-hands/csharp

    class Program
    {
        static void Main(string[] args)
        {
            string hand1 = "KS 2H 5C JD TD";
             //hand1 = "KS 2H 5C JD";
            try
            {
                PokerHand hand = new PokerHand(hand1);
                Console.WriteLine(hand.HandIsValid(hand1));
                hand.Sort();
                Console.WriteLine(hand.ToString());
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
        int validNumberOfCards = 5;

        public PokerHand(string hand)
        {
            if (!HandIsValid(hand))
            {
                throw new ArgumentException("Invalid poker hand string");
            }
            Hand = hand.ToUpper().Split(Separator);        
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

            HashSet<string> cards = new HashSet<string>();
            foreach (string card in hand.Split(Separator))
            {
                if (!(card.Length == 2) || !(Ranks.Contains(card[0]) || Suits.Contains(card[1])))
                {
                    return false;
                }
                cards.Add(card);
            }
            return cards.Count == validNumberOfCards;
        }

        public void Sort(int outerCounter = 100)
        {
            if (outerCounter == 100)
            {
                outerCounter = validNumberOfCards - 1;
            }
            if (outerCounter == 0)
            {
                return;
            }
               
            for (int innerCounter = 0; innerCounter < outerCounter; innerCounter++)
            {
                if (FirstIsSmaller(Hand[innerCounter], Hand[innerCounter + 1]))
                {
                    string temp = Hand[innerCounter];
                    Hand[innerCounter] = Hand[innerCounter + 1];
                    Hand[innerCounter + 1] = temp;
                }
            }
            Sort(outerCounter - 1);
        }

        private bool FirstIsSmaller(string card1, string card2)
        {
            if (Array.IndexOf(Ranks, card1[0]) < Array.IndexOf(Ranks, card2[0]))
            {
                return true;
            }
            if (Array.IndexOf(Ranks, card1[0]) > Array.IndexOf(Ranks, card2[0]))
            {
                return false;
            }
            return (Array.IndexOf(Suits, card1[1]) < Array.IndexOf(Suits, card2[1]));
        }

        override public string ToString()
        {
            return String.Join(Separator.ToString(), Hand);
        }
    }
}
