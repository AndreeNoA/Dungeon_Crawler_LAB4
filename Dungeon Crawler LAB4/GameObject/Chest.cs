using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    class Chest : GameObject, IActionable
    {
        private const string Symbol = "C";

        public Chest(int h, int v) : base(h, v)
        {

        }
        public override string GetSymbol()
        {
            return Symbol;
        }

        public override void Action(Player player)
        {
            if (player.position.Horizontal == 1 && player.position.Vertical == 5 || player.position.Horizontal == 7 && player.position.Vertical == 3)
            {
                Console.WriteLine("You picked up a normal key");
                Console.ReadKey();
                player.normalKey = true;
            }
            else if (player.position.Horizontal == 1 && player.position.Vertical == 9)
            {
                Console.WriteLine("You picked up a red key.");
                Console.ReadKey();
                player.redKey = true;
            }
            else if (player.position.Horizontal == 5 && player.position.Vertical == 10)
            {
                Console.WriteLine("You picked up a blue key.");
                Console.ReadKey();
                player.blueKey = true;
            }
        }
    }
}
