using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool IsBlackJack
        {
            get
            {
                return Value == BLACK_JACK;
            }
        }

        public bool IsBusted
        {
            get
            {
                return Value > BLACK_JACK;
            }
        }

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
    }
}