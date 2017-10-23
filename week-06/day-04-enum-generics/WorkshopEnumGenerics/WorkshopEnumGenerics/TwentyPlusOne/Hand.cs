using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Hand
    {
        private HashSet<Card> cards = new HashSet<Card>();
        private const int BLACK_JACK = 21;
        private int value;

        public bool IsTwentyOne => Value == BLACK_JACK;
        public bool IsBusted => Value > BLACK_JACK;
        public bool IsInGame => Value <= BLACK_JACK;

        public int Value { get => value;
            private set => this.value = value; }

        public void Add(Card card)
        {
            if(card == null)
            {
                throw new ArgumentNullException("No card given to hand.");
            }
            else if (cards.Contains(card))
            {
                throw new ArgumentException($"Hand already contains {card}.");
            }

            // TODO update logic with player's choice: ace = 11 / ace = 1 / split?

            cards.Add(card);
            Value = UpdateValue();
        }

        private int UpdateValue()
        {
            // is there any cards?
            if (cards.Count == 0)
            {
                return 0;
            }

            // calculate
            Value = cards.ToList().Sum(card => card.Value);

            // blackjack or under?
            if (Value <= BLACK_JACK)
            {
                return Value;
            }

            for (int i = 0; i < cards.Where(card => card.Rank == Rank.Ace).Count(); i++)
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
            if (cards.Count == 0)
            {
                return "No card in the hand.";
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The value of the hand is: {Value}");
            cards.ToList().ForEach(card => stringBuilder.AppendLine(card.ToString()));
            return stringBuilder.ToString();
        }
    }
}