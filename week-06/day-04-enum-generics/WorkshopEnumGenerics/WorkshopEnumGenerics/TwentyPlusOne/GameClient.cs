using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    class GameClient
    {
        private GameServer gameServer;

        private Dictionary<ConsoleKey, PlayerDecision> ConsoleKeyToPlayerDecisionDict = new Dictionary<ConsoleKey, PlayerDecision>()
        {
            { ConsoleKey.H, PlayerDecision.Hit },
            { ConsoleKey.S, PlayerDecision.Stand }
        };

        public GameClient(GameServer gameServer)
        {
            this.gameServer = gameServer;
            gameServer.PlayerMoney = 1000;
        }

        internal void Play()
        {
            ConsoleKey key;
            do
            {                
                PlayOneRound();
                if (gameServer.PlayerMoney < 25)
                {
                    Console.WriteLine("Sorry, you have run out of cash.");
                    break;
                }
                Console.WriteLine("Would you like to play one more round? Press (ESC) to quit.");
                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.Escape);

            Console.WriteLine("Have a nice day, see you soon.");
        }

        private void PlayOneRound()
        {
            if (gameServer.PlayerMoney < 25)
            {
                Console.WriteLine("Sorry, you have run out of cash.");
                return;
            }

            EnterBet();

            gameServer.FirstDeal();

            if (!gameServer.PlayerHandIsImprovable)
            {
                Console.WriteLine(gameServer);
            }

            while (gameServer.PlayerHandIsImprovable)
            {
                ImprovePlayerHand();
            }
            ImproveDealerHand();

            gameServer.PayOut();

            Console.WriteLine(gameServer);
        }

        private void EnterBet()
        {
            int bet;
            Console.WriteLine($"You have ${gameServer.PlayerMoney} worth chips.");
            do
            {
                Console.WriteLine($"Please enter your bet (min $25, max ${gameServer.PlayerMoney}):");
                bet = Convert.ToInt32(Console.ReadLine());
            } while (bet < 25 || bet > gameServer.PlayerMoney);        
            gameServer.PlayerBet = bet;
        }

        private void ImprovePlayerHand()
        {
            PlayerDecision playerDecision;
            Console.WriteLine(gameServer);
            ConsoleKey key;

            Console.WriteLine("What is your decision? (H)it / (S)tand");
            do
            {
                key = Console.ReadKey().Key;
            } while (!ConsoleKeyToPlayerDecisionDict.Keys.Contains(key));

            playerDecision = ConsoleKeyToPlayerDecisionDict[key];

            if (playerDecision == PlayerDecision.Hit)
            {
                gameServer.ImprovePlayerHand();
            }
            else if (playerDecision == PlayerDecision.Stand)
            {
                gameServer.PlayerSignedStand = true;
            }
        }

        private void ImproveDealerHand()
        {
            if (gameServer.player.IsInGame && gameServer.DealerHandIsImprovable)
            {
                gameServer.ImproveDealerHand();
            }
        }
    }
}
