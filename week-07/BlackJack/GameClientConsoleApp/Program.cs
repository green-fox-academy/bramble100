using System;
using BlackJack.GameServer;

namespace GameClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GameClient gameClient = new GameClient(new GameController(new GameModel()));
            gameClient.Play();
            Console.ReadKey();
        }
    }
}
