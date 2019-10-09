using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  TODO
             *      Hide what atleast 1 room contains.
             *      Fix EndofGame
             *      Clean up the code
             */

            Map map = Map.CreateMap();
            Player player = new Player();
            
            //EndOfGame endOfGame = new EndOfGame(); // run win or lose method

            Console.WriteLine("Welcome to dungeon crawler!\nPress any key to start");

            do
            {
                Console.WriteLine("Your current healthpoints is " + player.playerHealthPoints);
                map.PrintMap(player);
                player.PlayerMove(map, player);
                Console.Clear();

            } while (true);                 
        }
    }
}
