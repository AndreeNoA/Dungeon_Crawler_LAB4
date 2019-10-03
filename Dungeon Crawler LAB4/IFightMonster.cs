using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler_LAB4
{
    interface IFightMonster
    {
        int Damage { get; set; }
        int Health { get; set; }
        void Fight();
    }
}
