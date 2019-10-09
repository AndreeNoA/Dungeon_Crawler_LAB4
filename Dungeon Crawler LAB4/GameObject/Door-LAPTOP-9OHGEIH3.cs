using System;

namespace DungeonCrawlerVersion61
{
    class Door : GameObject
    {
        private const string Symbol = "D";

        public Door(int h, int v) : base(h, v)
        {

        }
        public override string GetSymbol()
        {
            return Symbol;
        }
    }
}