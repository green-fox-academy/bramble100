using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Card
    {
        private Rank rank;
        private Suit suit;
        private CardColor cardColor;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public Rank Rank { get => rank; private set => rank = value; }
        public Suit Suit { get => suit; private set => suit = value; }
        public CardColor CardColor { get => cardColor; private set => cardColor = value; }

        public override string ToString() => $"{rank} of {suit}";
    }
}