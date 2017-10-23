using System;
using System.Text;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class GameServer
    {
        public bool IsATie
            => dealer.Value == player.Value;

        public bool IsWonByPlayer
            => !player.IsBusted 
            && (dealer.IsBusted || player.Value > dealer.Value);

        public bool IsWonByDealer
            => !dealer.IsBusted 
            && (player.IsBusted || dealer.Value > player.Value);

        public bool PlayerHandIsImprovable
            => FirstDealHasDone 
            && !PlayerSignedStand
            && player.IsImprovable;

        public bool DealerHandIsImprovable
            => FirstDealHasDone 
            && dealer.IsImprovable;

        public bool GameIsOver 
            => AnyHandIsBusted ||
            (FirstDealHasDone 
            && !PlayerHandIsImprovable 
            && !DealerHandIsImprovable);

        public bool FirstDealHasDone
        {
            get => firstDealHasDone;
            set
            {
                if (!firstDealHasDone)
                {
                    firstDealHasDone = value;
                }
            }
        }

        public bool PlayerSignedStand
        {
            get => playerSignedStand;
            set
            {
                if (!playerSignedStand)
                {
                    playerSignedStand = value;
                }
            }
        }

        public bool AnyHandIsBusted => dealer.IsBusted || player.IsBusted;

        public int PlayerMoney
        {
            get => playerMoney;
            set
            {
                if (!FirstDealHasDone)
                {
                    playerMoney = value;
                }
            }
        }

        public int PlayerBet
        {
            get => playerBet;
            set
            {
                if (!FirstDealHasDone && value <= PlayerMoney)
                {
                    playerBet = value;
                    PlayerMoney -= PlayerBet;
                }                    
            }
        }

        public Deck deck;
        public BlackJackHandDealer dealer;
        public BlackJackHandPlayer player;
        private bool firstDealHasDone;
        private bool playerSignedStand;
        private int playerMoney;
        private int playerBet;

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
            dealer = new BlackJackHandDealer();
            player = new BlackJackHandPlayer();
            FirstDealHasDone = false;
            PlayerSignedStand = false;

            deck.Shuffle();
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

        internal void PayOut()
        {
            if (IsATie)
            {
                playerMoney += playerBet;
            }
            else if (IsWonByPlayer)
            {
                playerMoney += 2 * playerBet;
            };
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
            stringBuilder.AppendLine($"Player's money: ${playerMoney}");
            return stringBuilder.ToString();
        }
    }
}