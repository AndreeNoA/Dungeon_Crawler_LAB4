using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    public class Position
    {
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public Position(int h, int v)
        {
            this.Horizontal = h;
            this.Vertical = v;            
        }
    }
}
