using System;
using System.Text;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Game
    {

        public bool IsATie
            => dealer.Value == player.Value;

        public bool IsWonByPlayer
            => !player.IsBusted && (dealer.IsBusted || player.Value > dealer.Value);

        public bool IsWonByDealer
            => !dealer.IsBusted && (player.IsBusted || dealer.Value > player.Value);

        public Deck deck;
        public Hand dealer;
        public Hand player;

        public Game()
        {
            deck = new Deck();
            dealer = new Hand();
            player = new Hand();

            deck.Shuffle();
        }

        public void Play()
        {
            FirstDeal();
            if (!dealer.IsTwentyOne || !player.IsTwentyOne)
            {
                ImprovePlayerHand();
                if (!player.IsTwentyOne && !player.IsBusted)
                {
                    ImproveDealerHand();
                }
            }
            Console.WriteLine(ToString());
            Console.WriteLine(DetermineResult());
        }

        private void ImprovePlayerHand()
        {
            PlayerDecision playerDecision;
            while (player.IsInGame && !player.IsTwentyOne)
            {
                Console.WriteLine(ToString());
                playerDecision = GetPlayerDecision();
                if (playerDecision == PlayerDecision.Hit)
                {
                    Deal(player);
                }
                else if (playerDecision == PlayerDecision.Stand)
                {
                    return;
                }
            }
        }

        private void ImproveDealerHand()
        {
            while (dealer.Value < 17)
            {
                Deal(dealer);
            }
        }

        private string DetermineResult()
        {
            return IsATie ? "It is a tie/push." :
                $"{(IsWonByDealer ? "Dealer" : "Player")} has won.";
        }

        private PlayerDecision GetPlayerDecision()
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

        private void FirstDeal()
        {
            Deal(player);
            Deal(dealer);
            Deal(player);
            Deal(dealer);
        }

        private void Deal(Hand hand)
            => hand.Add(deck.PullFirst());

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("BlackJack game.");
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("Dealer's hand:");
            stringBuilder.AppendLine(dealer.ToString());
            stringBuilder.AppendLine("---------------");
            stringBuilder.AppendLine("Player's hand:");
            stringBuilder.AppendLine(player.ToString());
            return stringBuilder.ToString();
        }
    }
}