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

    }
}