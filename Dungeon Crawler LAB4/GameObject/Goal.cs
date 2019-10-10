using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    class Goal : GameObject, IActionable
    {
        private const string Symbol = "G";

        public Goal(int h, int v) : base(h, v)
        {

        }
        public override string GetSymbol()
        {
            return Symbol;
        }

        EndOfGame endGame = new EndOfGame();
        public override void Action(Player player)
        {
            endGame.Actemdion(player);
        }
    }
}
