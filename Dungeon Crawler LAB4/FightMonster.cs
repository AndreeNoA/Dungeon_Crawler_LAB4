using Dungeon_Crawler_LAB4;
using System;

namespace DungeonCrawlerVersion61
{
    public class FightMonster : IFightMonster
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int PlayerHealthPoints { get; set; }
        public int PlayerAttackDamage { get; set; }
        public Monster monster { get; set; }

        public bool turn = true;


        public FightMonster(ref int playerHealthPoints, int playerDamage, Monster monster)
        {
            this.monster = monster;
            PlayerHealthPoints = playerHealthPoints;
            PlayerAttackDamage = playerDamage;
            Fight();            
        }

        public void Fight()
        {
            while (PlayerHealthPoints > 0 && monster.monsterHealth > 0)
            {
                if (turn == true)
                {
                    Console.WriteLine("You have "+ PlayerAttackDamage);
                    //code for the fight with the monster
                    
                }
            }
        }
    }
}