using System;
using System.Text;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class GameServer
    {

        public bool IsATie
            => dealer.Value == player.Value;

        public bool IsWonByPlayer
            => !player.IsBusted && (dealer.IsBusted || player.Value > dealer.Value);

        public bool IsWonByDealer
            => !dealer.IsBusted && (player.IsBusted || dealer.Value > player.Value);

        public bool PlayerHandIsImprovable
            => FirstDealHasDone && player.IsInGame && !PlayerSignedStand && !player.IsTwentyOne;
        public bool PlayerSignedStand;

        public bool DealerHandIsImprovable
            => FirstDealHasDone && dealer.Value < DEALER_DECISION_POINT;

        public bool GameIsOver => FirstDealHasDone && !PlayerHandIsImprovable && !DealerHandIsImprovable;
            

        public Deck deck;
        public BlackJackHand dealer;
        public BlackJackHand player;
        public bool FirstDealHasDone;
        private int DEALER_DECISION_POINT = 17;

        public GameServer()
        {
            Initialize();
        }

        public void Clear()
        {
            Initialize();
        }

        private void Initialize()
        {
            deck = new Deck();
            dealer = new BlackJackHand();
            player = new BlackJackHand();
            FirstDealHasDone = false;
            PlayerSignedStand = false;

            deck.Shuffle();
        }

        /// <summary>
        /// For debug purposes only.
        /// </summary>
        public void PlayForDebug()
        {
            FirstDeal();
            if (!dealer.IsTwentyOne || !player.IsTwentyOne)
            {
                ImprovePlayerHandForDebug();
                if (!player.IsTwentyOne && !player.IsBusted)
                {
                    ImproveDealerHand();
                }
            }
            Console.WriteLine(ToString());
        }

        public void FirstDeal()
        {
            if (!FirstDealHasDone)
            {
                Deal(player);
                Deal(dealer);
                Deal(player);
                Deal(dealer);
                FirstDealHasDone = true;
            }
        }
        /// <summary>
        /// For debug purposes only.
        /// </summary>
        public void ImprovePlayerHandForDebug()
        {
            PlayerDecision playerDecision;
            while (player.IsInGame && !player.IsTwentyOne)
            {
                Console.WriteLine(ToString());
                playerDecision = GetPlayerDecisionForDebug();
                if (playerDecision == PlayerDecision.Hit)
                {
                    Deal(player);
                }
                else if (playerDecision == PlayerDecision.Stand)
                {
                    PlayerSignedStand = true;
                    return;
                }
            }
        }

        public void ImprovePlayerHand()
        {
            if (PlayerHandIsImprovable)
            {
                Deal(player);
            }
        }

        public void ImproveDealerHand()
        {
            while (DealerHandIsImprovable)
            {
                Deal(dealer);
            }
        }
        /// <summary>
        /// For debug purposes only.
        /// </summary>
        /// <returns></returns>
        private PlayerDecision GetPlayerDecisionForDebug()
        {
            ConsoleKey key;

            Console.WriteLine("What is your decision?");
            Console.WriteLine("(H)it / (S)tand");
            do
            {
                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.H && key != ConsoleKey.S);

            return key == ConsoleKey.H ? PlayerDecision.Hit : PlayerDecision.Stand;
        }

        private void Deal(Hand hand)
            => hand.Add(deck.PullFirst());

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("BlackJack game.");
            stringBuilder.AppendLine("---------------");
            if (GameIsOver)
            {
                stringBuilder.AppendLine(IsATie ? "It is a tie/push." : $"{(IsWonByDealer ? "Dealer" : "Player")} has won.");
                stringBuilder.AppendLine("---------------");
            }            
            stringBuilder.AppendLine("Dealer's hand:");
            stringBuilder.AppendLine(dealer.ToString());
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("Player's hand:");
            stringBuilder.AppendLine(player.ToString());
            return stringBuilder.ToString();
        }
    }
}