using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace DungeonCrawlerVersion61.Monsters
{
    internal class FightingMonsters : MonsterBase, IFightMonster
    {
        public FightingMonsters(int Damage, int Health, string Name) : base(Damage, Health, Name)
        {
        }
        public void Fight(Player player)
        {
            Console.WriteLine(
                $"You see a monster in the room. It's {Name}!\n" +
                $"{Name} has {Damage} in damage and {Health} healthpoints.\n" +
                $"You have {player.playerAttackDamage} in damage\n" +
                $"Press any key when you are ready to fight {Name}");
            Console.ReadKey();
            Console.Clear();
            bool turn = true; // true = player turn, false = monster turn
            do
            {
                if (turn == true)
                {
                    Console.WriteLine($"You hit the {Name} for {player.playerAttackDamage} ");
                    player.playerHealthPoints = player.playerHealthPoints - Damage;
                    Console.WriteLine("You have " + player.playerHealthPoints + " left");
                    Thread.Sleep(1000);
                    turn = false;
                }
                else if (turn == false)
                {
                    Console.WriteLine($"{Name} hit you for {Damage}");
                    Health = Health - player.playerAttackDamage;
                    Console.WriteLine($"{Name} have {Health} left");
                    Thread.Sleep(1000);
                    turn = true;
                }
            } 

            while (player.playerHealthPoints > 0 && Health > 0);
                Thread.Sleep(1000);
                Console.Clear();

                if (Health > 0)
                {
                    Console.WriteLine($"You lost the fight against {Name}");
                    EndOfGame endOfGame = new EndOfGame();
                    endOfGame.Actemdion(player);
                }
                else
                {
                    Console.WriteLine($"After a hard fight against {Name} you are victorious!");
                }
        }
    }
}