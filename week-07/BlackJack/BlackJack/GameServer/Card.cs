using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.GameServer
{
    public class Card : IEquatable<Card>
    {
        private Rank rank;
        private Suit suit;
        private static Dictionary<Rank, int> ValueDict = new Dictionary<Rank, int>
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

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public Rank Rank { get => rank; private set => rank = value; }
        public Suit Suit { get => suit; private set => suit = value; }
        public int Value => ValueDict[Rank];

        public override string ToString() => $"{rank} of {suit}";
        public override bool Equals(object obj)
        {
            return Equals(obj as Card);
        }
        public bool Equals(Card other)
        {
            return other != null &&
                   rank == other.rank &&
                   suit == other.suit;
        }
        public override int GetHashCode() => base.GetHashCode();
    }
}