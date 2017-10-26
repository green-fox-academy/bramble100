using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.GameServer
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private Random random = new Random();

        public Deck()
        {
            for (int suit = 0; suit  < typeof(Suit).GetEnumValues().Length; suit ++)
            {
                for (int rank = 0; rank < typeof(Rank).GetEnumValues().Length; rank++)
                {
                    cards.Add(new Card((Rank)rank, (Suit)suit));
                }
            }
        }
        public Deck(List<Card> cards, Random random)
        {
            this.cards = cards ?? throw new ArgumentNullException(nameof(cards));
            this.random = random ?? throw new ArgumentNullException(nameof(random));
        }
        public void Shuffle()
        {
            List<Card> shuffledCards = new List<Card>();
            while (cards.Count > 0)
            {
                shuffledCards.Add(PullRandom());
            }
            cards = shuffledCards;
        }
        public Card PullFirst()
        {
            if(cards.Count == 0)
            {
                return null;
            }

            Card card = cards.First();
            cards.RemoveAt(0);
            return card;
        }
        public Card PullLast()
        {
            if (cards.Count == 0)
            {
                return null;
            }

            Card card = cards.Last();
            cards.RemoveAt(cards.Count-1);
            return card;
        }
        public Card PullRandom()
        {
            if (cards.Count == 0)
            {
                return null;
            }

            int cardID = random.Next(cards.Count);
            Card card = cards.ElementAt(cardID);
            cards.RemoveAt(cardID);
            return card;
        }
        public string GetCardsList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            cards.ForEach(card => stringBuilder.AppendLine(card.ToString()));
            return stringBuilder.ToString();
        }
        public override string ToString() 
            => $"The deck consists of {cards.Count} cards.";
    }
}