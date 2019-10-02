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

        public long Position()
        {
            long playerPosition = Int64.Parse(playerPositionHorizontal.ToString() + playerPositionVertical.ToString());
            return playerPosition;
        }
    }
}