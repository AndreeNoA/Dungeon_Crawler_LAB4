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
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);
            IFightMonster monster;
            
            if (randomNumber == 1)
            {

                Console.WriteLine("2");

                monster = new Dragon(10,10,"Dragon");
                monster.Fight(player);

            }
            else if(randomNumber == 2)
            {
                Dragon snake = new Dragon(10, 55, "Snake");
                snake.Fight(player);
            }
            else if (randomNumber == 3)
            {
                Dragon dog = new Dragon(110, 155, "Dog");
                dog.Fight(player);
            }
            else if (randomNumber == 4)
            {
                Dragon johan = new Dragon(110, 155, "Dog");
                johan.Fight(player);
            }
            Console.ReadKey();
            
            // slumpa ett nummer mellan 1 - 3
            // if random = 1 -> skapa upp en fight med en drake

            // if random = 2 -> skapa upp en fight med ett troll




        }

      


        // public string monsterName { get; set; }
        // public int monsterHealth { get; set; }
        // public int monsterDamage { get; set; }
        //
        // public Monster (string monsterName, int monsterHealth, int monsterDamage)
        // {
        //     this.monsterName = monsterName;
        //     this.monsterHealth = monsterHealth;
        //     this.monsterDamage = monsterDamage;
        // }
    }
}