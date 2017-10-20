using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Hand
    {
        private HashSet<Card> cards = new HashSet<Card>();
        public const int BLACK_JACK = 21;
        private int value;

        public bool IsBlackJack => Value == BLACK_JACK;

        public bool IsBusted => Value > BLACK_JACK;

        public bool IsInGame => Value < BLACK_JACK;

        public int Value { get => value; private set => this.value = value; }

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
            cards.Add(card);
            Value = UpdateHandValue();
        }

        private int UpdateHandValue()
        {
            // is there any cards?
            if (cards.Count == 0)
            {
                return 0;
            }

            // calculate
            Value = cards.ToList().Sum(card => Card.Value[card.Rank]);

            // blackjack or under?
            if (Value <= BLACK_JACK)
            {
                return Value;
            }

            // if contains and ace, reduce value by 10
            if (cards.ToList().Exists(card => card.Rank == Rank.Ace))
            {
                Value -= 10;
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