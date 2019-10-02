using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    internal class PlayerInput
    {
        public char PlayerMovementInput()
        {
            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.W:
                    return 'W';
                case ConsoleKey.D:
                    return 'D';
                case ConsoleKey.S:
                    return 'S';
                case ConsoleKey.A:
                    return 'A';
                //case ConsoleKey.Q:        TODO
                //use health pot
                //case ConsoleKey.E:
                //use mana pot
                default:
                    return 'P';
            }
        }
    }
}