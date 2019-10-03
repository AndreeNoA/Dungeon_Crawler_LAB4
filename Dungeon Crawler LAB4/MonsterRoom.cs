using System;

namespace DungeonCrawlerVersion61
{

    internal class MonsterRoom
    {
                
        public void MonsterType(int playerPositionHorizontal, int playerPositionVertical, ref int playerHealthPoints, int playerDamage)
        {
            string playerPosition = playerPositionHorizontal.ToString() + playerPositionVertical.ToString();
            switch (playerPosition)
            {
                case "15":
                    Monster monsterGiant = new Monster("Giant", 20, 10);
                    FightMonster fightGiant = new FightMonster(ref playerHealthPoints, playerDamage, monsterGiant);
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