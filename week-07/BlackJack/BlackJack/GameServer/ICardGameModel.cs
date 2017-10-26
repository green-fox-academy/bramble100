using System.Collections.Generic;

namespace BlackJack.GameServer
{
    public interface ICardGameModel
    {
        HashSet<Card> PlayerHand { get; }
        HashSet<Card> DealerHand { get; }
        bool IsTied { get; }
        bool PlayerHasHigherScore { get; }

        void DealForPlayer();
        void DealForDealer();
        void ShuffleDeck();
        string PlayerToString();
        string DealerToString();
    }
}