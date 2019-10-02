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
            ValidMovement validMovement = new ValidMovement(); //check if move is possible (not walking into walls etc) 
            OutputMap outputMap = new OutputMap();
            CheckRoom checkRoom = new CheckRoom(); // check what kind of room it is, and send back info to main
            EndOfGame endOfGame = new EndOfGame(); // run win or lose method

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
                if (validMovement.IsMovementValid(inputDirection, player.playerPositionHorizontal, player.playerPositionVertical, map.exploredSquares))
                {
                    player.PlayerMove(inputDirection);
                    Console.Clear();
                }
                else
                {
                    //Console.WriteLine("Invalid movement");
                    //Console.ReadKey();
                    //Console.Clear();
                    Console.WriteLine("Invalid movement");
                    Console.ReadKey();
                    Console.Clear();
                }
                //checkRoom.Checkroom();//check player.Position to determine what room    
            }
            while (player.playerHealthPoints > 0);

            endOfGame.EndGame(player.playerHealthPoints);
        }
    }
}
