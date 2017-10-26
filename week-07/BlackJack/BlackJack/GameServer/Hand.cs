using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.GameServer
{
    public class Hand
    {
        private const int BLACK_JACK = 21;

        private HashSet<Card> cards = new HashSet<Card>();
        private int value;

        public Hand(HashSet<Card> cards)
        {
            this.cards = cards ?? throw new ArgumentNullException(nameof(cards));
        }

        public Hand()
        {
        }

        public bool IsTwentyOne => Value == BLACK_JACK;
        public bool IsBusted => Value > BLACK_JACK;
        public bool IsInGame => Value <= BLACK_JACK;

        public int Value { get => value;
            protected set => this.value = value; }

        public HashSet<Card> Cards => cards;

        public void Add(Card card)
        {
            if(card == null)
            {
                throw new ArgumentNullException("No card given to hand.");
            }
            else if (Cards.Contains(card))
            {
                throw new ArgumentException($"Hand already contains {card}.");
            }

            Cards.Add(card);
            UpdateValue();
        }

        private int UpdateValue()
        {
            // is there any cards?
            if (Cards.Count == 0)
            {
                return 0;
            }

            // calculate
            Value = Cards.ToList().Sum(card => card.Value);

            // blackjack or under?
            if (Value <= BLACK_JACK)
            {
                return Value;
            }

            for (int i = 0; i < Cards.Where(card => card.Rank == Rank.Ace).Count(); i++)
            {
                Value -= 10;
                if (IsInGame)
                {
                    return Value;
                }
            }
            return Value;
        }

        public override string ToString()
        {
            if (Cards.Count == 0)
            {
                return "No card in the hand.";
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The value of the hand is: {Value}");
            Cards.ToList().ForEach(card => stringBuilder.AppendLine(card.ToString()));
            return stringBuilder.ToString();
        }
    }
}