using System;

namespace DungeonCrawlerVersion61
{
    internal class EndOfGame
    {
        public void Actemdion(Player player)
        {
          if (player.playerHealthPoints > 0)
          {
                Console.Clear();
                Console.WriteLine("You won the game!\nYou had " + player.playerHealthPoints + " left");
                Console.ReadKey();
                Environment.Exit(0);
            }
          else
                Console.WriteLine("You lost. Loser!");
                Console.ReadKey();
                Environment.Exit(0);
        }
    }
}