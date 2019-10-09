using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    public class Player 
    {

        public Position position { get; set; }

        public int playerHealthPoints = 500;        
        public  int playerAttackDamage = 5;
        public bool sword1 = false;
        public bool sword2 = false;

        public Player()
        {
            position = new Position(1, 1);
        }

        public  int PlayerDamage ()
        {
            if (sword1 == true && sword2 == true)
            {
                return playerAttackDamage = 12 ;
            }
            else if (sword1 == true)
            {
                return playerAttackDamage = 8;
            }
            else if (sword2 == true)
            {
                return playerAttackDamage = 7 ;
            }
            else
                return playerAttackDamage = 5;
        }

        public void PlayerMove(Map map, Player player)
        {
            while (true)
            {
                var input = Console.ReadKey();

                if (!IsValidMovementInput(input.Key))
                {
                    Console.WriteLine("Invalid input..");
                    continue;
                }

                var newPosition = GetNewPositionFromMovement(input.Key, this.position);

                if (map.IsWallOnPosition(newPosition))
                {
                    Console.WriteLine("You hit a wall and lost 5 HP.");
                    this.playerHealthPoints -= 15;
                    return;
                }
                if (map.IsMonsterOnPosition(newPosition, player));
                
                if(map.IsHPPotOnPosition(newPosition, player));

                if (map.IsTrapOnPosition(newPosition, player));







                this.position = newPosition;
                playerHealthPoints -= 5;
                return;             
            }            
        }

        private bool IsValidMovementInput(ConsoleKey input)
        {
            return input == ConsoleKey.W || input == ConsoleKey.D || input == ConsoleKey.S || input == ConsoleKey.A;
        }

        private Position GetNewPositionFromMovement(ConsoleKey input, Position pos)
        {
            switch (input)
            {
                case ConsoleKey.W:
                    return new Position(pos.Horizontal, pos.Vertical - 1);
                    
                case ConsoleKey.D:
                    return new Position(pos.Horizontal + 1, pos.Vertical);
                    
                case ConsoleKey.S:
                    return new Position(pos.Horizontal, pos.Vertical + 1);
                    
                case ConsoleKey.A:
                    return new Position(pos.Horizontal -1, pos.Vertical);
                    
            }
            //This should never happend...
            return new Position(1, 1);
        }



    }
}
