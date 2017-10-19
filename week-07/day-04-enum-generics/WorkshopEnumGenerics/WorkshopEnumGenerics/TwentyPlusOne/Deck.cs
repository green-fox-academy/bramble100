using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Deck
    {
        private List<Card> theoreticallyAvailableCards = new List<Card>();
        private List<Card> cards = new List<Card>();
        private Random random = new Random();

        public Deck()
        {
            for (int suit = 0; suit  < typeof(Suit).GetEnumValues().Length; suit ++)
            {
                for (int rank = 0; rank < typeof(Rank).GetEnumValues().Length; rank++)
                {
                    theoreticallyAvailableCards.Add(new Card((Rank)rank, (Suit)suit));
                }
            }
            theoreticallyAvailableCards.ForEach(card => cards.Add(card));
        }

        public void ShuffleDeck()
        {

        }

        public void PullFirst()
        {

        }

        public void PullLast()
        {

        }

        public Card PullRandom()
        {
            int cardID = random.Next(cards.Count);
            Card card = cards.ElementAt(cardID);
            cards.RemoveAt(cardID);
            return card;
        }

        public override string ToString()
        {
            return $"The deck consists of {cards.Count} cards.";
        }
    }
}
