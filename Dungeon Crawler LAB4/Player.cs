using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    internal class Player
    {
        public int playerHealthPoints = 500;
        
        public int playerPositionHorizontal = 1;
        public int playerPositionVertical = 1;
        public int playerAttackDamage = 5;
        public bool sword1 = false;
        public bool sword2 = false;

        public int PlayerDamage (bool sword1, bool sword2)
        {
            if (sword1 == true && sword2 == true)
            {
                return playerAttackDamage = 12;
            }
            else if (sword1 == true)
            {
                return playerAttackDamage = 10;
            }
            else if (sword2 == true)
            {
                return playerAttackDamage = 7;
            }
            else
                return playerAttackDamage = 5;
        }

        public void PlayerMove(char movementDirection)
        {
            switch (movementDirection)
            {
                case 'W':
                    playerPositionVertical--;
                    break;
                case 'D':
                    playerPositionHorizontal++;
                    break;
                case 'S':
                    playerPositionVertical++;
                    break;
                case 'A':
                    playerPositionHorizontal--;
                    break;
                //case ConsoleKey.Q:        TODO
                //use health pot
                //case ConsoleKey.E:
                //use mana pot
                default:
                    Console.WriteLine("Use WASD to move");
                    break;
            }
        }
    }
}