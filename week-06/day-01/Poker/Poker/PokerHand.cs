using System.Collections.Generic;

namespace Poker
{
    public class PokerHand : HashSet<PlayingCard>
    {
        public bool IsValid { get; set; }

        public PokerHand(string inputString)
        {
            IsValid = false;
            string[] playingCards = inputString.Split(' ');
            foreach (var card in playingCards)
            {
                PlayingCard tempCard = new PlayingCard(card);
                if (tempCard.IsValid)
                {
                    Add(tempCard);
                }
            }

            IsValid = Count == 5;
        }
    }
}
