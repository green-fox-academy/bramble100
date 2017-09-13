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
            const int validNumberOfCards = 5;

            string hand1 = "KS 2H 5C JD TD";
             //hand1 = "KS 2H 5C JD";
            try
            {
                PokerHand hand = new PokerHand(hand1, validNumberOfCards);
                Console.WriteLine("Original user output \"{0}\", it is considered {1}.", hand1, hand.HandIsValid(hand1) ? "valid" : "invalid");
                if (hand.HandIsValid(hand1))
                {
                    hand.Sort();
                    Console.WriteLine("Sorted hand is \"{0}\"", hand.ToString());
                }
            }
            catch (ArgumentException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }

    public class PokerHand
    {
        char[] Ranks = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
        char[] Suits = { 'S', 'H', 'D', 'C' };
        char Separator = ' ';
        string[] Hand = { };
        int validNumberOfCards;

        public PokerHand(string userInput, int validNumberOfCards)
        {
            userInput = userInput.ToUpper();
            this.validNumberOfCards = validNumberOfCards;

            if (HandIsValid(userInput))
            {
                Hand = userInput.ToUpper().Split(Separator);
            }
            Hand = userInput.Split(Separator);
        }

        public bool HandIsValid(string handString)
        {
            string[] cardsToCheck = handString.Split(Separator);
            HashSet<string> cardsToCheckSet = new HashSet<string>(cardsToCheck); // remove duplicates

            if (cardsToCheckSet.Count != validNumberOfCards)
            {
                return false;
            }

            foreach (string card in cardsToCheckSet)
            {
                if (!CardIsValid(card))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CardIsValid(string card)
        {
            return !(!(card.Length == 2) || !(Ranks.Contains(card[0]) || !Suits.Contains(card[1])));
        }

        private bool CardIsValid_VeryLongMethod(string card)
        {
            if (card.Length != 2)
            {
                return false;
            }
            if (!Ranks.Contains(card[0]))
            {
                return false;
            }
            if (!Suits.Contains(card[1]))
            {
                return false;
            }
            return true;
        }

        private bool CardIsValid_LongMethod(string card)
        {
            if (card.Length != 2 || !Ranks.Contains(card[0]) || !Suits.Contains(card[1]))
            {
                return false;
            }
            return true;
        }

        public void Sort(int outerCounter = Int32.MaxValue)
        {
            outerCounter = outerCounter == Int32.MaxValue ? validNumberOfCards - 1 : outerCounter;

            if (outerCounter == 0)
            {
                return;
            }
               
            for (int innerCounter = 0; innerCounter < outerCounter; innerCounter++)
            {
                if (FirstIsSmaller(Hand[innerCounter], Hand[innerCounter + 1]))
                {
                    SwapCardWithNext(innerCounter);
                }
            }
            Sort(outerCounter - 1);
        }

        private void SwapCardWithNext(int innerCounter)
        {
            string temp = Hand[innerCounter];
            Hand[innerCounter] = Hand[innerCounter + 1];
            Hand[innerCounter + 1] = temp;
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
