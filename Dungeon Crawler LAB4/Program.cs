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
            Map map = new Map();
            PlayerInput playerInput = new PlayerInput();
            Player player = new Player(); // hp, mp, inventory, player position
            ValidMovement validMovement = new ValidMovement(); 
            OutputMap outputMap = new OutputMap();
            CheckRoom checkRoom = new CheckRoom(); // check what kind of room it is, and send back info to main
            EndOfGame endOfGame = new EndOfGame(); // run win or lose method
            MonsterRoom monsterRoom = new MonsterRoom();
            ChestRoom chestRoom = new ChestRoom();
            Door door = new Door();
            Trap trap = new Trap();

            Console.WriteLine("Welcome to dungeon crawler!\nPress any key to start");
            Console.ReadKey();
            Console.Clear();

            do
            {
                /*
                 *  Check if movement is valid
                 *  Move player to room //DONE
                 *  Check what kind of room
                 *  Run room (Return new info to player class
                 */
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

                char room = checkRoom.RoomCheck(player.playerPositionHorizontal, player.playerPositionVertical, map.exploredSquares, ref player.playerHealthPoints);
                switch (room)
                {
                    case 'M':
                        monsterRoom.MonsterType(player.playerPositionHorizontal, player.playerPositionVertical, ref player.playerHealthPoints);
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
