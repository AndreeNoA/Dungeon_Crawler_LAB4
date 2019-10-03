using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    class Program
    {
        static void Main(string[] args)
        {
            //pjäser och spelplanen:
            Map map = new Map();
            //Map map = Map.CreateMap();
            Player player = new Player(); // hp, mp, inventory, player position
            MonsterRoom monsterRoom = new MonsterRoom();
            ChestRoom chestRoom = new ChestRoom();
            Door door = new Door();
            Trap trap = new Trap();

            //Vilkor / regler kring spelet:
            PlayerInput playerInput = new PlayerInput();
            CheckRoom checkRoom = new CheckRoom(); // check what kind of room it is, and send back info to main
            EndOfGame endOfGame = new EndOfGame(); // run win or lose method
            ValidMovement validMovement = new ValidMovement(); 

            //Grafik till spelet:
            OutputMap outputMap = new OutputMap();

            Console.WriteLine("Welcome to dungeon crawler!\nPress any key to start");
            Console.ReadKey();
            Console.Clear();

            do
            {
                outputMap.PrintMap(player.playerPositionHorizontal, player.playerPositionVertical);
                var inputDirection = playerInput.PlayerMovementInput();
                if (validMovement.IsMovementValid(inputDirection, player.playerPositionHorizontal, player.playerPositionVertical, map.exploredSquares, ref player.playerHealthPoints))
                {
                    player.PlayerMove(inputDirection);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You lost hp" + player.playerHealthPoints);
                    Console.ReadKey();
                    Console.Clear();
                }

                player.PlayerDamage(player.sword1, player.sword2); //Updating player damage, checking inventory for swords
                char room = checkRoom.RoomCheck(player.playerPositionHorizontal, player.playerPositionVertical, map.exploredSquares, ref player.playerHealthPoints);
                switch (room)
                {
                    case 'M':
                        monsterRoom.MonsterType(player.playerPositionHorizontal, player.playerPositionVertical, ref player.playerHealthPoints, player.playerAttackDamage);
                        break;
                    case 'D':
                        Console.WriteLine("Door");
                        break;
                    case 'T':
                        Console.WriteLine("Trap");
                        break;
                    case 'C':
                        Console.WriteLine("Chest");
                        break;
                    case 'E':
                        Console.WriteLine("End");
                        break;
                }
            }
            while (player.playerHealthPoints > 0);

            endOfGame.EndGame(player.playerHealthPoints);
        }
    }
}
