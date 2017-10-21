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
        private DeckColor deckColor;

        private static Dictionary<Rank, int> 
            ValueDict = new Dictionary<Rank, int>
        {
            {Rank.Two, 2 },
            {Rank.Three, 3 },
            {Rank.Four, 4 },
            {Rank.Five, 5 },
            {Rank.Six, 6 },
            {Rank.Seven, 7 },
            {Rank.Eight, 8 },
            {Rank.Nine, 9 },
            {Rank.Ten, 10 },
            {Rank.Jack, 10 },
            {Rank.Queen, 10 },
            {Rank.King, 10 },
            {Rank.Ace, 11 }
        };

        public Card(Rank rank, 
            Suit suit, 
            DeckColor deckColor = DeckColor.Red)
        {
            this.rank = rank;
            this.suit = suit;
            this.deckColor = deckColor;
        }

        public int Value => ValueDict[Rank];

        public Rank Rank { get => rank; private set => rank = value; }
        public Suit Suit { get => suit; private set => suit = value; }
        public DeckColor DeckColor { get => deckColor; private set => deckColor = value; }

        public override string ToString() => $"{rank} of {suit}";
    }
}