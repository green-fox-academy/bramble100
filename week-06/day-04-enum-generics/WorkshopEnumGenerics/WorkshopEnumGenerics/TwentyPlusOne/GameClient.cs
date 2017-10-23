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
        }

        internal void Play()
        {
            ConsoleKey key;
            do
            {
                PlayOneRound();
                Console.WriteLine("Would you like to play one more round? Press (ESC) to quit.");
                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.Escape);

            Console.WriteLine("Have a nice day, see you soon.");
        }

        private void PlayOneRound()
        {
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
            Console.WriteLine(gameServer);
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
