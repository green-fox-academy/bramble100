using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.GameServer;

namespace GameClientConsoleApp
{
    public class GameClient
    {
        private GameController gameController;

        private Dictionary<ConsoleKey, PlayerDecision> ConsoleKeyToPlayerDecisionDict = new Dictionary<ConsoleKey, PlayerDecision>()
        {
            { ConsoleKey.H, PlayerDecision.Hit },
            { ConsoleKey.S, PlayerDecision.Stand }
        };

        public GameClient()
        {
            gameController = new GameController(new GameModel());
        }

        public GameClient(GameController gameController)
        {
            this.gameController = gameController;
        }

        public void Play()
        {
            ConsoleKey key;
            do
            {
                PlayOneRound();
                Console.WriteLine("Would you like to play one more round? Press (ESC) to quit.");
                key = Console.ReadKey().Key;
                Console.Clear();
            } while (key != ConsoleKey.Escape);

            Console.WriteLine("Have a nice day, see you soon.");
        }

        private void PlayOneRound()
        {
            gameController.RequestNewGame();
            gameController.RequestFirstDeal();

            if (!gameController.PlayerHandIsImprovable)
            {
                Console.Clear();
                Console.WriteLine(gameController);
            }

            while (gameController.PlayerHandIsImprovable)
            {
                ImprovePlayerHand();
            }
            Console.Clear();
            Console.WriteLine(gameController);
        }

        private void ImprovePlayerHand()
        {
            Console.Clear();
            Console.WriteLine(gameController);
            ConsoleKey key;

            Console.WriteLine("What is your decision? (H)it / (S)tand");
            do
            {
                key = Console.ReadKey().Key;
            } while (!ConsoleKeyToPlayerDecisionDict.Keys.Contains(key));

            if (ConsoleKeyToPlayerDecisionDict[key].Equals(PlayerDecision.Hit))
            {
                gameController.ImprovePlayerHand();
            }
            else if (ConsoleKeyToPlayerDecisionDict[key].Equals(PlayerDecision.Stand))
            {
                gameController.SignStand();
            }
        }
    }
}
