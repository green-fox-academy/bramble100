using System.Collections.Generic;

namespace BlackJack.GameServer
{
    public interface ICardGameController
    {
        HashSet<Card> PlayerHand { get; }
        HashSet<Card> DealerHand { get; }
        bool IsFinished { get; }
        bool IsTied { get; }
        bool IsWonByDealer { get; }
        bool IsWonByPlayer { get; }

        void RequestNewGame();
    }
}