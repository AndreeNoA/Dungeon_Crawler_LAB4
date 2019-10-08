using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    class BlueChest : GameObject
    {
        private const string Symbol = "C";

        public BlueChest(int h, int v) : base(h, v)
        {

        }
        public override string GetSymbol()
        {
            return Symbol;
        }

        public override void GetKeyFromChest(Player player)
        {
            //Console.WriteLine(player.position.Horizontal); // 1
            //Console.WriteLine(player.position.Vertical); // 5
            //Console.ReadKey();
            if (player.position.Horizontal == 1 && player.position.Vertical == 5)
            {
                Console.WriteLine("Normal key");
                Console.ReadKey();
                player.normalKey = true;
            }
            else if (player.position.Horizontal == 7 && player.position.Vertical == 3)
            {
                Console.WriteLine("Normal key");
                Console.ReadKey();
                player.normalKey = true;
            }
            else if (player.position.Horizontal == 1 && player.position.Vertical == 9)
            {
                Console.WriteLine("Red key(bottom corner)");
                Console.ReadKey();
                player.redKey = true;
            }
            else if (player.position.Horizontal == 5 && player.position.Vertical == 10)
            {
                Console.WriteLine("Blue key");
                Console.ReadKey();
                player.blueKey = true;
            }
        }
    }
}
