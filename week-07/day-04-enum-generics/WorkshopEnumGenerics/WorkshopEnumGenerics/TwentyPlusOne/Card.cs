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

        public Rank Rank { get => rank; set => rank = value; }
        public Suit Suit { get => suit; set => suit = value; }
        public CardColor CardColor { get => cardColor; set => cardColor = value; }
    }
}