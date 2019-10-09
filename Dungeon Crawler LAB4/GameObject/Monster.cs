using System;
using DungeonCrawlerVersion61.Monsters;
namespace DungeonCrawlerVersion61
{
    class Monster : GameObject
    {
        private const string Symbol = "M";
        public Monster(int h, int v) : base(h, v)
        {
        }
        public override string GetSymbol()
        {
            return Symbol;
        }
        public string GetNewSymbol()
        {
            return " ";
        }
        public override void Action(Player player)
        {
            Console.Clear();
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);
            player.PlayerDamage();
            
            if (randomNumber == 1)
            {
                IFightMonster Giant = new FightingMonsters(2, 10, "Giant");
                Giant.Fight(player);
            }
            else if (randomNumber == 2)
            {
                IFightMonster MonsterSnake = new FightingMonsters(5, 20, "Monster Snake");
                MonsterSnake.Fight(player);
                player.sword1 = true;
            }
            else if (randomNumber == 3)
            {
                IFightMonster MonsterCat = new FightingMonsters(10, 10, "Monster Cat");
                MonsterCat.Fight(player);
                player.sword2 = true;
            }
            else if (randomNumber == 4)
            {
                IFightMonster MonsterDragon = new FightingMonsters(8, 15, "Monster Dragon");
                MonsterDragon.Fight(player);
            }
            Console.ReadKey();
        }        
    }
}