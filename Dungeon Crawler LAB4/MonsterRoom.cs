using System;

namespace DungeonCrawlerVersion61
{

    internal class MonsterRoom
    {
        public void MonsterType(int playerPositionHorizontal, int playerPositionVertical, ref int playerHealthPoints)
        {
            string playerPosition = playerPositionHorizontal.ToString() + playerPositionVertical.ToString();
            switch (playerPosition)
            {
                case "15":
                    Console.WriteLine("Monster Giant");
                    playerHealthPoints--;
                    break;
                case "19":
                    Console.WriteLine("Monster Snake");
                    break;
                case "91":
                    Console.WriteLine("Monster Cat");
                    break;
                default:
                    Console.WriteLine("Monster Dragon");
                    break;
            }
        }
    }
}