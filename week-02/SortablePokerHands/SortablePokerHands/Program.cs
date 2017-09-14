using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            char[] Suits = { 'C', 'D', 'H', 'S' };
            char Separator = ' ';

            string hand1 = "KS 2H 5C JD TD";

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Test suite");

            CardValidatorTest("2H", true, Ranks, Suits); // good uppercase
            CardValidatorTest("td", true, Ranks, Suits); // good lowercase
            CardValidatorTest("cD", false, Ranks, Suits); // wrong rank
            CardValidatorTest("3x", false, Ranks, Suits); // wrong rank
            CardValidatorTest("4", false, Ranks, Suits); // missing suit
            CardValidatorTest("c99", false, Ranks, Suits); // wrong suit
            CardValidatorTest("", false, Ranks, Suits);

            Console.WriteLine();

            HandValidatorTest("KS 2H 5C JD TD", true, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS 2H 5C JD", false, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS2H5CJDTD", false, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS,2H,5C,JD:TD", false, Ranks, Suits, validNumberOfCards, Separator);
            HandValidatorTest("KS KS 5C JD TD", false, Ranks, Suits, validNumberOfCards, Separator);

            Console.WriteLine();

            SortingTest("KS 2H", "KS 2H", Ranks, Suits, 2, Separator);
            SortingTest("2H KS", "KS 2H", Ranks, Suits, 2, Separator);
            SortingTest("KS 2H 5C", "KS 5C 2H", Ranks, Suits, 3, Separator);
            SortingTest("AS AH AD AC", "AS AH AD AC", Ranks, Suits, 4, Separator);

            Console.WriteLine();

            FirstIsSmallerTest("KS", "2S", Ranks, Suits, false);
            FirstIsSmallerTest("2S", "KS", Ranks, Suits, true);
            FirstIsSmallerTest("AS", "AH", Ranks, Suits, false);
            FirstIsSmallerTest("AH", "AS", Ranks, Suits, true);

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

        private static void FirstIsSmallerTest(string card1, string card2, char[] ranks, char[] suits, bool expectedResult)
        {
            bool actualResult = PokerHand.FirstIsSmaller(card1, card2, ranks, suits);
            Console.WriteLine(" Testing FirstIsSmallerTest, input cards: {0} and {1}, expected result: {2}, actual result {3}, succeded: {4}",
                card1,
                card2,
                expectedResult,
                actualResult,
                actualResult == expectedResult);
        }

        private static void SortingTest(string unsortedHand, 
            string expectedSortedHand, 
            char[] ranks, 
            char[] suits, 
            int validNumberOfCards, 
            char separator)
        {
            PokerHand hand = new PokerHand(unsortedHand, ranks, suits, validNumberOfCards, separator);
            hand.Sort(ranks, suits, validNumberOfCards);
            string actualResult = hand.ToString(separator);
            Console.WriteLine(" Testing hand sorting, input string: {0}, expected to be {1}, result: {2}, succeded: {3}",
                unsortedHand,
                expectedSortedHand,
                actualResult,
                actualResult == expectedSortedHand);
        }

        private static void HandValidatorTest(string sampleHand, 
            bool expectedResult, 
            char[] Ranks, 
            char[] Suits, 
            int validNumberOfCards, 
            char Separator
            )
        {
            bool actualResult = PokerHand.IsValid_WithRegex(sampleHand, Ranks, Suits, validNumberOfCards, Separator);
            Console.WriteLine(" Testing hand validator, input string: {0}, expected to be {1}, result: {2}, succeded: {3}",
                sampleHand,
                expectedResult,
                actualResult,
                actualResult == expectedResult);
        }

        public static void CardValidatorTest(string sampleCard, 
            bool expectedResult, 
            char[] Ranks, 
            char[] Suits)
        {
            bool actualResult = PokerHand.CardIsValid_WithRegex(sampleCard, Ranks, Suits);
            Console.WriteLine(" Testing card validator, input string: {0}, expected to be {1}, result: {2}, succeded: {3}",
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
        }

        public static bool IsValid(string handString, char[] Ranks, char[] Suits, int validNumberOfCards, char Separator)
        {
            HashSet<string> cardsToCheckSet = new HashSet<string>(handString.ToUpper().Split(Separator)); // remove duplicates

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

        public static bool IsValid_WithRegex(string handString, char[] Ranks, char[] Suits, int validNumberOfCards, char Separator)
        {
            // BUGGY for "KS KS 5C JD TD" !!! guess why ???
            string pattern = @"^([2-9TJQKA]{1}[SHDC]{1}[ ]){4}[2-9TJQKA]{1}[SHDC]{1}$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            return r.IsMatch(handString); ;

        }

        public static bool CardIsValid(string card, char[] Ranks, char[] Suits)
        {
            card = card.ToUpper();
            return !((card.Length != 2 || !Ranks.Contains(card[0]) || !Suits.Contains(card[1])));
        }

        public static bool CardIsValid_WithRegex(string card, char[] Ranks, char[] Suits)
        {
            string pattern = @"^[23456789TJQKA]{1}[SHDC]{1}$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            return r.IsMatch(card); ;
        }

        public static bool CardIsValid_WithLambda(string card, char[] Ranks, char[] Suits) =>
            !((card.Length != 2 || !Ranks.Contains(card.ToUpper()[0]) || !Suits.Contains(card.ToUpper()[1])));

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

            if (outerCounter <= 0)
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

        private void SwapCardWithNext(int i)
        {
            string temp = Hand[i];
            Hand[i] = Hand[i + 1];
            Hand[i + 1] = temp;
        }

        public static bool FirstIsSmaller(string card1, string card2, char[] Ranks, char[] Suits)
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
