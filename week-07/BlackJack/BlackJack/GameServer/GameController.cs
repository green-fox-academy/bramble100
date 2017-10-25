using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.GameServer
{
    public class GameController
    {
        public static bool IsStartable { get; private set; }
        public static bool BetIsPlaceable { get; private set; }
        public static int PlacedBet { get; private set; }
        public static bool FirstDealIsRequestable { get; private set; }
        public static bool PlayerHandIsImproveable { get; private set; }
        public static Card DealerCard { get; private set; }
        public static int DealerCardValue { get; private set; }
        public static Hand PlayerHand { get; private set; }
        public static int PlayerCardValue { get; private set; }
        public static Hand DealerHand { get; private set; }
        public static int DealerHandValue { get; private set; }
        public static bool PlayerHasWon { get; private set; }
        public static bool DealerHasWon { get; private set; }
        public static bool IsTie { get; private set; }
        public static bool IsFinished { get; private set; }

        private GameModel game;
        private static bool winningIsCollectable;
        private static int collectableWinning;

        public static void PlaceBet(int bet)
        {
            throw new NotImplementedException();
        }

        public static void RequestFirstDeal()
        {
            throw new NotImplementedException();
        }

        public static void RequestForHit()
        {
            throw new NotImplementedException();
        }

        public static void SignStand()
        {
            throw new NotImplementedException();
        }

        public static int CollectWinning()
        {
            throw new NotImplementedException();
        }
    }
}
