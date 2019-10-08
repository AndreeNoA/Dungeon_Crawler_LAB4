using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61.Monsters
{
    internal class Dragon : MonsterBase , IFightMonster
    {
        public Dragon(int Damage, int Health, string Name) : base(Damage, Health, Name)
        {
        }

        public void Fight(Player player)
        {
            Console.Write("Du får möte en " + Name);
            Console.Write($"Den har {Damage} i skada och {Health} i liv.");

            bool turn = true; // true = player turn, false = monster turn
            do
            {
                if(turn == true)
                {
                    Console.WriteLine($"You hit the {Name} for {player.playerAttackDamage} ");
                    player.playerHealthPoints = player.playerHealthPoints - Damage;
                    Console.WriteLine("You have " + player.playerHealthPoints + " left");


                    turn = false;
                }else if(turn == false)
                {
                    Console.WriteLine($"{Name} hit you for {Damage}");
                    Health = Health - player.playerAttackDamage;
                    Console.WriteLine($"{Name} have {Health} left");
                    turn = true;
                }



            } while (player.playerHealthPoints > 0 && Health > 0);

            if (Health > 0)
            {
                Console.WriteLine($"You lost the fight against {Name}");
                EndOfGame endOfGame = new EndOfGame();
                endOfGame.EndGame();
            }
            else
            {
                Console.WriteLine($"After a hard fight against {Name} you are victorious!\nPress any key to continue");
            }
            
            //Börja slåss med draken (fight loop tills nån dör)
        }
    }
}
