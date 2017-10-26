using System.Collections.Generic;

namespace BlackJack.GameServer
{
    public interface IBlackJackGameModel
    {
        HashSet<Card> PlayerHand { get; }
        HashSet<Card> DealerHand { get; }
        bool PlayerHandIsImprovable { get; }
        bool DealerHandIsImprovable { get; }
        int PlayerHandValue { get; }
        int DealerHandValue { get; }
        bool PlayerIsBusted { get; }
        bool DealerIsBusted { get; }
        bool DealerHasHigherScore { get; }
        bool FirstDealHasDone { get; }
        bool IsTied { get; }
        bool PlayerHasHigherScore { get; }

        void DealForPlayer();
        void DealForDealer();
        void ShuffleDeck();
        string PlayerToString();
        string DealerToString();
    }
}