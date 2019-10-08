using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61.Monsters
{
    class MonsterBase
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }

        public MonsterBase(int Damage, int Health, string Name)
        {
            this.Damage = Damage;
            this.Health = Health;
            this.Name = Name;
        }


    }
}
