using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawlerVersion61
{
    public class Map
    {

        public static char[,] exploredSquares = new char[12, 12] {  {'#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#'},
                                                                    {'#' , 'E' , ' ' , 'H' , 'I' , ' ' , ' ' , ' ' , ' ' , 'M' , 'H' , '#'},
                                                                    {'#' , ' ' , 'I' , 'I' , 'I' , ' ' , 'I' , ' ' , 'I' , 'I' , 'I' , '#'},
                                                                    {'#' , ' ' , 'D' , ' ' , ' ' , ' ' , 'I' , ' ' , 'C' , 'I' , 'G' , '#'},
                                                                    {'#' , ' ' , 'T' , ' ' , 'I' , 'I' , 'I' , 'D' , 'I' , 'I' , ' ' , '#'},
                                                                    {'#' , 'M' , 'I' , 'I' , 'I' , ' ' , ' ' , ' ' , 'I' , 'H' , ' ' , '#'},
                                                                    {'#' , 'G' , 'I' , ' ' , ' ' , ' ' , 'I' , 'T' , ' ' , 'I' , ' ' , '#'},
                                                                    {'#' , 'I' , 'I' , ' ' , 'I' , 'I' , 'I' , ' ' , ' ' , 'I' , ' ' , '#'},
                                                                    {'#' , ' ' , ' ' , ' ' , 'I' , ' ' , 'D' , ' ' , ' ' , 'I' , ' ' , '#'},
                                                                    {'#' , 'M' , 'I' , ' ' , 'I' , ' ' , 'I' , 'I' , ' ' , 'I' , 'D' , '#'},
                                                                    {'#' , 'B' , 'I' , ' ' , ' ' , ' ' , 'R' , 'I' , ' ' , 'M' , ' ' , '#'},
                                                                    {'#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#'} };




        //private int rowSize { get; set; }
        //private int columnSize { get; set; }
        private List<GameObject> gameObjects { get; set; }

        public void PrintMap(Player player)
        {
            for (int v = 0; v < exploredSquares.GetLength(0); v++)
            {
                for (int h = 0; h < exploredSquares.GetLength(1); h++)
                {
                    var gameObject = gameObjects.Where(go => go.horizontal == h && go.vertical == v).FirstOrDefault();

                    if (player.position.Vertical == v && player.position.Horizontal == h)
                    {
                        Console.Write("@");
                    }
                    else if (gameObject is Wall)
                    {
                        Console.Write("#");
                    }
                    else if (ShouldWeRenderGameObject(player, h, v))
                    {
                        if(gameObject == null)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(gameObject.GetSymbol());
                            if (gameObject is InnerWall)
                            {
                                gameObjects.Remove(gameObject);
                                gameObjects.Add(new Wall(h, v));
                            }
                        }                        
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
            
        }


        private bool ShouldWeRenderGameObject(Player player, int h, int v)
        {
            if ((player.position.Vertical - 1) == v && player.position.Horizontal == h)
            {
                return true;
            }
            else if (player.position.Vertical == v && (player.position.Horizontal + 1) == h)
            {
                return true;
            }
            else if ((player.position.Vertical + 1) == v && player.position.Horizontal == h)
            {
                return true;
            }
            else if (player.position.Vertical == v && (player.position.Horizontal - 1) == h)
            {
                return true;
            }           

            return false;
        }

        public bool IsWallOnPosition(Position pos)
        {
            var gameObject = gameObjects.Where(go => go.horizontal == pos.Horizontal && go.vertical == pos.Vertical).FirstOrDefault();

            if(gameObject != null && gameObject.GetSymbol() == "#")
            {
                return true;
            }

            return false;
        }
        public bool IsMonsterOnPosition(Position pos, Player player)
        {
            var gameObject = gameObjects.Where(go => go.horizontal == pos.Horizontal && go.vertical == pos.Vertical).FirstOrDefault();

            if(gameObject != null && gameObject.GetSymbol() == "M")
            {
                gameObject.Action(player);
                gameObjects.Remove(gameObject);                
                return true;
            }
            

            return false;
        }public bool IsHPPotOnPosition(Position pos, Player player)
        {
            var gameObject = gameObjects.Where(go => go.horizontal == pos.Horizontal && go.vertical == pos.Vertical).FirstOrDefault();

            if (gameObject != null && gameObject.GetSymbol() == "H")
            {

                gameObject.GetHealthPotion(player);

                gameObjects.Remove(gameObject);
                return true;
            }
            return false;
        }


        public static Map CreateMap()
        {
            var map = new Map();
            //map.rowSize = exploredSquares.GetLength(0);
            //map.columnSize = exploredSquares.GetLength(1);
            map.gameObjects = new List<GameObject>();
            for (int v = 0; v < exploredSquares.GetLength(0); v++)
            {
                for (int h = 0; h < exploredSquares.GetLength(1); h++)
                {
                    if (exploredSquares[v, h] == '#')
                    {
                        map.gameObjects.Add(new Wall(h, v));
                    }
                    else if (exploredSquares[v, h] == 'T')
                    {
                        map.gameObjects.Add(new Trap(h, v));
                    }
                    else if (exploredSquares[v, h] == 'D')
                    {
                        map.gameObjects.Add(new Door(h, v));
                    }
                    else if (exploredSquares[v, h] == 'M')
                    {
                        map.gameObjects.Add(new Monster(h, v));
                    }
                    else if (exploredSquares[v, h] == 'B')
                    {
                        map.gameObjects.Add(new BlueChest(h, v));
                    }
                    else if (exploredSquares[v, h] == 'H')
                    {
                        map.gameObjects.Add(new HealthPotion(h, v));
                    }
                    else if (exploredSquares[v, h] == 'E')
                    {
                        map.gameObjects.Add(new Entrance(h, v));
                    }
                    else if (exploredSquares[v, h] == 'G')
                    {
                        map.gameObjects.Add(new Goal(h, v));
                    }
                    else if (exploredSquares[v, h] == 'I')
                    {
                        map.gameObjects.Add(new InnerWall(h, v));
                    }
                    else if (exploredSquares[v, h] == 'R')
                    {
                        map.gameObjects.Add(new RedChest(h, v));
                    }
                }                
            }

            return map;
        }
    }
}