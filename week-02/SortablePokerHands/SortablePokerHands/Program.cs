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
            char[] Ranks = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
            char[] Suits = { 'S', 'H', 'D', 'C' };
            char Separator = ' ';

            string hand1 = "KS 2H 5C JD TD";

            Console.WriteLine("Test suite");

            CardValidatorTest("2H", true, Ranks, Suits);
            CardValidatorTest("td", true, Ranks, Suits);
            CardValidatorTest("c9", false, Ranks, Suits);
            CardValidatorTest("c99", false, Ranks, Suits);
            CardValidatorTest("", false, Ranks, Suits);

            Console.WriteLine();

            HandValidatorTest("KS 2H 5C JD TD", true, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS 2H 5C JD", false, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS2H5CJDTD", false, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS,2H,5C,JD:TD", false, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS KS 5C JD TD", false, Ranks, Suits, validNumberOfCards, Separator);

            Console.WriteLine();

            PokerHand hand = new PokerHand(hand1, Ranks, Suits, validNumberOfCards, Separator);
            Console.WriteLine("Original user output \"{0}\", it is considered {1}.", hand1, PokerHand.IsValid(hand1, Ranks, Suits, validNumberOfCards, Separator) ? "valid" : "invalid");
            if (PokerHand.IsValid(hand1, Ranks, Suits, validNumberOfCards, Separator))
            {
                hand.Sort(Ranks, Suits, validNumberOfCards);
                Console.WriteLine("Sorted hand is \"{0}\"", hand.ToString());
            }
            Console.ReadKey();
        }

        private static void HandValidatorTest(string sampleHand, 
            bool expectedResult, 
            char[] Ranks, 
            char[] Suits, 
            int validNumberOfCards, 
            char Separator
            )
        {
            bool actualResult = PokerHand.IsValid(sampleHand, Ranks, Suits, validNumberOfCards, Separator);
            Console.WriteLine("Testing hand validator, input string: {0}, expected to be {1}, result: {2}, succeded: {3}",
                sampleHand,
                expectedResult,
                actualResult,
                actualResult == expectedResult);
        }

        public static void CardValidatorTest(string sampleCard, bool expectedResult, char[] Ranks, char[] Suits)
        {
            bool actualResult = PokerHand.CardIsValid(sampleCard, Ranks, Suits);
            Console.WriteLine("Testing card validator, input string: {0}, expected to be {1}, result: {2}, succeded: {3}",
                sampleCard,
                expectedResult,
                actualResult,
                actualResult == expectedResult);
        }
    }

    public class PokerHand
    {
        string[] Hand = { };

        public PokerHand(string userInput, char[] Ranks, char[] Suits, int validNumberOfCards, char Separator)
        {
            userInput = userInput.ToUpper();

            if (IsValid(userInput, Ranks, Suits, validNumberOfCards, Separator))
            {
                Hand = userInput.ToUpper().Split(Separator);
            }
            Hand = userInput.Split(Separator);
        }

        public static bool IsValid(string handString, char[] Ranks, char[] Suits, int validNumberOfCards, char Separator)
        {
            string[] cardsToCheck = handString.Split(Separator);
            HashSet<string> cardsToCheckSet = new HashSet<string>(cardsToCheck); // remove duplicates

            if (cardsToCheckSet.Count != validNumberOfCards)
            {
                return false;
            }

            foreach (string card in cardsToCheckSet)
            {
                if (!CardIsValid(card, Ranks, Suits))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CardIsValid(string card, char[] Ranks, char[] Suits)
        {
            card = card.ToUpper();
            return !(!(card.Length == 2) || !(Ranks.Contains(card[0])) || !(Suits.Contains(card[1])));
        }

        public static bool CardIsValid_LongMethod(string card, char[] Ranks, char[] Suits)
        {
            card = card.ToUpper();
            if (card.Length != 2 || !Ranks.Contains(card[0]) || !Suits.Contains(card[1]))
            {
                return false;
            }
            return true;
        }

        public static bool CardIsValid_VeryLongMethod(string card, char[] Ranks, char[] Suits)
        {
            card = card.ToUpper();
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

        public void Sort(char[] Ranks, char[] Suits, int validNumberOfCards, int outerCounter = Int32.MaxValue)
        {
            outerCounter = outerCounter == Int32.MaxValue ? validNumberOfCards - 1 : outerCounter;

            if (outerCounter == 0)
            {
                return;
            }
               
            for (int innerCounter = 0; innerCounter < outerCounter; innerCounter++)
            {
                if (FirstIsSmaller(Hand[innerCounter], Hand[innerCounter + 1], Ranks, Suits))
                {
                    SwapCardWithNext(innerCounter);
                }
            }
            Sort(Ranks, Suits, outerCounter - 1);
        }

        private void SwapCardWithNext(int innerCounter)
        {
            string temp = Hand[innerCounter];
            Hand[innerCounter] = Hand[innerCounter + 1];
            Hand[innerCounter + 1] = temp;
        }

        public bool FirstIsSmaller(string card1, string card2, char[] Ranks, char[] Suits)
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

        public string ToString(char Separator)
        {
            return String.Join(Separator.ToString(), Hand);
        }
    }
}
