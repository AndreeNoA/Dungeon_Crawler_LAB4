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
            Map map = Map.CreateMap();
            //Map map = Map.CreateMap();
            Player player = new Player(); // hp, mp, inventory, player position
            

            //Vilkor / regler kring spelet:
            //PlayerInput playerInput = new PlayerInput();
            //CheckRoom checkRoom = new CheckRoom(); // check what kind of room it is, and send back info to main
            //EndOfGame endOfGame = new EndOfGame(); // run win or lose method
            //ValidMovement validMovement = new ValidMovement(); //klasser bör vara subjektiv inte verb. 

            //Grafik till spelet:
            //OutputMap outputMap = new OutputMap();

            Console.WriteLine("Welcome to dungeon crawler!\nPress any key to start");
            //Console.Read();
            //Console.Clear();

            do
            {
                //Console.WriteLine(player.playerHealthPoints);

                map.PrintMap(player);
                player.PlayerMove(map, player);
                //validMovement.IsMovementValid(player.PlayerMove(dire), player.playerPositionHorizontal, player.playerPositionVertical, ref player.playerHealthPoints );

                //player.DidPlayerHitGameObject();
                //Verifiera om användaren har hamnat på något GameObject

                //Kör Action() på det gameObjectet
                Console.Clear();

            } while (true);
            

     
        }
    }
}
