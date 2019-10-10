using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    public class Player
    {

        public Position position { get; set; }

        public int playerHealthPoints = 500;        
        public int playerAttackDamage = 5;
        public bool bronzeSword = false;
        public bool silverSword = false;
        public bool redKey = false;
        public bool blueKey = false;
        public bool normalKey = false;

        public Player()
        {
            position = new Position(1, 1);
        }

        public int UpdatePlayerDamage ()
        {
            if (bronzeSword == true && silverSword == true)
            {
                return playerAttackDamage = 12;
            }
            else if (bronzeSword == true)
            {
                return playerAttackDamage = 8;
            }
            else if (silverSword == true)
            {
                return playerAttackDamage = 7;
            }
            else
                return playerAttackDamage = 5;
        }

        public void PlayerMoveAndRoomAction(Map map, Player player)
        {
            while (true)
            {
                var input = Console.ReadKey();
                Console.WriteLine();
                if (!IsValidMovementInput(input.Key))
                {
                    Console.WriteLine("Invalid input..\n" +
                        "Use W,A,S,D to move ");
                    continue;
                }

                var newPosition = GetNewPositionFromMovement(input.Key, this.position);
                var gameObject = map.gameObjects.Where(go => go.horizontal == newPosition.Horizontal && go.vertical == newPosition.Vertical).FirstOrDefault();

                if (gameObject is Wall)
                {
                    Console.WriteLine("You hit a wall and lost 15 HP.");
                    this.playerHealthPoints -= 15;
                    Console.WriteLine(playerHealthPoints);
  
                    Thread.Sleep(1000);
                    return;
                }
                if (gameObject is Door)
                {
                    if (newPosition.Horizontal == 2 && newPosition.Vertical == 3 && normalKey == true || newPosition.Horizontal == 7 && newPosition.Vertical == 4 && normalKey == true)
                    {
                        Console.WriteLine("You opened the door");
                        Console.ReadKey();
                        normalKey = false;
                        map.gameObjects.Remove(gameObject);
                    }
                    else if (newPosition.Horizontal == 6 && newPosition.Vertical == 8 && redKey == true)
                    {
                        Console.WriteLine("You opened the door");
                        Console.ReadKey();
                        player.redKey = false;
                        map.gameObjects.Remove(gameObject);
                    }
                    else if (newPosition.Horizontal == 10 && newPosition.Vertical == 9 && blueKey == true)
                    {
                        Console.WriteLine("You opened the door");
                        Console.ReadKey();
                        player.blueKey = false;
                        map.gameObjects.Remove(gameObject);
                    }
                    else
                    {
                        Console.WriteLine("The door is locked. Go and find a key to open it");
                        Console.ReadKey();
                        return;
                    }
                }
                               
                if (gameObject is IActionable)
                {
                    var actionable = (IActionable)gameObject;
                    gameObject.Action(player);
                    map.gameObjects.Remove(gameObject);                    
                }

                this.position = newPosition;
                playerHealthPoints -= 5; //Healthpoints lost on every move
                return;             
            }            
        }

        private bool IsValidMovementInput(ConsoleKey input)
        {
            return input == ConsoleKey.W || input == ConsoleKey.D || input == ConsoleKey.S || input == ConsoleKey.A;
        }

        private Position GetNewPositionFromMovement(ConsoleKey input, Position position)
        {
            switch (input)
            {
                case ConsoleKey.W:
                    return new Position(position.Horizontal, position.Vertical - 1);
                    
                case ConsoleKey.D:
                    return new Position(position.Horizontal + 1, position.Vertical);
                    
                case ConsoleKey.S:
                    return new Position(position.Horizontal, position.Vertical + 1);
                    
                case ConsoleKey.A:
                    return new Position(position.Horizontal -1, position.Vertical);
                    
            }
            //This should never happend...
            return new Position(1, 1);
        }

        public void PlayerSwordsInInventory()
        {
            if (bronzeSword == true && silverSword == true)
            {
                Console.WriteLine("You have combined two swords, and now have the golden sword");
            }
            else if (bronzeSword == true)
            {
                Console.WriteLine("You have the bronze sword");
            }
            else if (silverSword == true)
            {
                Console.WriteLine("You have the silver sword");
            }
        }
        public void PlayerKeysInInventory()
        {
            if (blueKey == true)
            {
                Console.WriteLine("You have the blue key");
            }
            if (redKey == true)
            {
                Console.WriteLine("You have the red key");
            }
            if (normalKey == true)
            {
                Console.WriteLine("You have a normal key");
            }
        }

    }
}
