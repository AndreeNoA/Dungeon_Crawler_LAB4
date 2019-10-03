using System;

namespace DungeonCrawlerVersion61
{
    internal class Trap
    {

        public void trapee(ref int playerHealth)
        {
            playerHealth = playerHealth -  10;
            Console.WriteLine(playerHealth);
            Console.ReadKey();

        }
    }
}