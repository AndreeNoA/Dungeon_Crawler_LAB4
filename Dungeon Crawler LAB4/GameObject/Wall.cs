

using System;

namespace DungeonCrawlerVersion61
{
    class Wall : GameObject
    {
        private const string Symbol = "#";

        public Wall(int h, int v) : base(h,v)
        {

        }
        public override string GetSymbol()
        {
            return Symbol;
        }

    }
}
