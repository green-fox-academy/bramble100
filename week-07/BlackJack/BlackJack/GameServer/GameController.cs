using System.Collections.Generic;
using System.Text;

namespace BlackJack.GameServer
{
    public class GameController : ICardGameController
    {
        public bool PlayerHandIsImprovable => gameModel.FirstDealHasDone
            && !PlayerSignedStand
            && gameModel.PlayerHandIsImprovable;

        public bool DealerHandIsImprovable => gameModel.FirstDealHasDone
            && !gameModel.PlayerIsBusted
            && gameModel.DealerHandIsImprovable;
        public bool IsWonByPlayer => !gameModel.PlayerIsBusted
            && (gameModel.DealerIsBusted || gameModel.PlayerHasHigherScore)
            && IsFinished;
        public bool IsWonByDealer => !gameModel.DealerIsBusted
            && (gameModel.PlayerIsBusted || gameModel.DealerHasHigherScore)
            && IsFinished;
        public bool IsTied => gameModel.IsTied
            && IsFinished;
        public bool PlayerSignedStand { get; private set; } = false;

        private bool isFinished = false;
        public bool IsFinished => isFinished 
            || gameModel.DealerIsBusted 
            || gameModel.PlayerIsBusted;

        public HashSet<Card> PlayerHand => gameModel.PlayerHand;
        public int PlayerHandValue => gameModel.PlayerHandValue;
        public HashSet<Card> DealerHand => gameModel.DealerHand;
        public int DealerHandValue => gameModel.DealerHandValue;

        private GameModel gameModel;

        public GameController(GameModel gameModel)
        {
            this.gameModel = gameModel;
            gameModel.ShuffleDeck();
            RequestFirstDeal();
        }

        public void RequestNewGame()
        {
            gameModel = null;
            gameModel = new GameModel();
            gameModel.ShuffleDeck();
            RequestFirstDeal();
        }

        public void RequestFirstDeal()
        {
            if (!gameModel.FirstDealHasDone)
            {
                gameModel.DealForPlayer();
                gameModel.DealForDealer();
                gameModel.DealForPlayer();
                gameModel.DealForDealer();
            }
        }

        public void ImprovePlayerHand()
        {
            if (PlayerHandIsImprovable)
            {
                gameModel.DealForPlayer();
            }
        }

        public void SignStand()
        {
            PlayerSignedStand = true;
            ImproveDealerHand();
            isFinished = true;
        }

        private void ImproveDealerHand()
        {
            while (DealerHandIsImprovable)
            {
                gameModel.DealForDealer();
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("BlackJack game.");
            stringBuilder.AppendLine("---------------");
            if (IsFinished)
            {
                stringBuilder.AppendLine(IsTied ? "It is a tie/push." : $"{(IsWonByDealer ? "Dealer" : "Player")} has won.");
                stringBuilder.AppendLine("---------------");
            }
            stringBuilder.AppendLine("Dealer's hand:");
            stringBuilder.AppendLine(gameModel.DealerToString());
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("Player's hand:");
            stringBuilder.AppendLine(gameModel.PlayerToString());
            return stringBuilder.ToString();
        }
    }
}