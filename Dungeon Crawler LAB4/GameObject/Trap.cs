using System;

namespace DungeonCrawlerVersion61
{
    class Trap : GameObject
     {
        private const string Symbol = "T";


        public Trap(int h, int v) : base(h, v)
        {

        }
        public override string GetSymbol()
        {
            return Symbol;
        }
        public override void WalkingOnTrap(Player player)
        {
            Console.Clear();
            Console.WriteLine("You just walked on a trap and lost 50 healthpoints");

            player.playerHealthPoints = player.playerHealthPoints - 50;
            Console.ReadKey();


        }

    }
}