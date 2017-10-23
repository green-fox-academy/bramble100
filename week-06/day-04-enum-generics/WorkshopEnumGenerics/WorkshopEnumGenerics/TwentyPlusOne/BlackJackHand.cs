using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class BlackJackHand : Hand
    {
        private const int BLACK_JACK = 21;

        public bool IsTwentyOne => Value == BLACK_JACK;
        public bool IsBusted => Value > BLACK_JACK;
        public bool IsInGame => Value <= BLACK_JACK;

        public override void Add(Card card)
        {
            base.Add(card);
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
    }
}
