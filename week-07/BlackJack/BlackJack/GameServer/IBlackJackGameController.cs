using System.Collections.Generic;

namespace BlackJack.GameServer
{
    public interface IBlackJackGameController
    {
        HashSet<Card> PlayerHand { get; }
        HashSet<Card> DealerHand { get; }
        bool PlayerHandIsImprovable { get; }
        bool DealerHandIsImprovable { get; }
        int PlayerHandValue { get; }
        int DealerHandValue { get; }
        bool IsFinished { get; }
        bool PlayerSignedStand { get; }
        bool IsTied { get; }
        bool IsWonByDealer { get; }
        bool IsWonByPlayer { get; }

        void ImprovePlayerHand();
        void RequestFirstDeal();
        void RequestNewGame();
        void SignStand();
    }
}