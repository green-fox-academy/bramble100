using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Hand
    {
        protected HashSet<Card> cards = new HashSet<Card>();
        protected int value;

        public int Value { get => value;
            protected set => this.value = value; }

        public virtual void Add(Card card)
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