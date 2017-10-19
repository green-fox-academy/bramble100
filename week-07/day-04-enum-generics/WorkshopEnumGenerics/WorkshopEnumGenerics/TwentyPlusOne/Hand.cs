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
        private int? value;

        public int Value
        {
            get
            {
                // is there any cards?
                if (cards.Count == 0)
                {
                    value = null;
                    return 0;
                }

                // hand needs recalculate?
                if (value != null)
                {
                    return (int)value;
                }

                // calculate
                value = cards.ToList().Sum(card => Card.Value[card.Rank]);

                // blackjack or under?
                if(value <= BLACK_JACK)
                {
                    return (int)value;
                }

                // if contains and ace, reduce value by 10
                if(cards.ToList().Exists(card => card.Rank == Rank.Ace))
                {
                    value -= 10;
                }

                return (int)value;
            }
        }

        public bool IsBlackJack => Value == BLACK_JACK;

        public bool IsBusted => Value > BLACK_JACK;

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
            value = null;
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