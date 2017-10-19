using System;
using System.Collections.Generic;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Hand
    {
        private HashSet<Card> cards = new HashSet<Card>();

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
        }
    }
}