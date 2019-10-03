using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    public class Map
    {

        public char[,] squares = new char[12, 12]         { {'#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , ' ' , '#'},
                                                            {'#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#'}};

        public char[,] exploredSquares = new char[12, 12] { {'#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#'},
                                                            {'#' , ' ' , ' ' , 'C' , '#' , ' ' , ' ' , ' ' , ' ' , 'M' , 'S' , '#'},
                                                            {'#' , ' ' , '#' , '#' , '#' , ' ' , '#' , ' ' , '#' , '#' , '#' , '#'},
                                                            {'#' , ' ' , 'D' , ' ' , ' ' , ' ' , '#' , ' ' , 'C' , '#' , ' ' , '#'},
                                                            {'#' , ' ' , 'T' , ' ' , '#' , '#' , '#' , 'D' , '#' , 'C' , ' ' , '#'},
                                                            {'#' , 'M' , '#' , '#' , '#' , ' ' , ' ' , ' ' , '#' , '#' , ' ' , '#'},
                                                            {'#' , 'S' , '#' , ' ' , ' ' , ' ' , '#' , 'T' , ' ' , '#' , ' ' , '#'},
                                                            {'#' , '#' , '#' , ' ' , '#' , '#' , '#' , ' ' , ' ' , '#' , ' ' , '#'},
                                                            {'#' , ' ' , ' ' , ' ' , '#' , ' ' , 'D' , ' ' , ' ' , '#' , ' ' , '#'},
                                                            {'#' , 'M' , '#' , ' ' , '#' , ' ' , '#' , '#' , ' ' , '#' , 'D' , '#'},
                                                            {'#' , 'C' , '#' , ' ' , ' ' , ' ' , 'C' , '#' , ' ' , 'M' , 'S' , '#'},
                                                            {'#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#' , '#'}};

        //public static Map CreateMap()
        //{
        //    var map = new Map();
        //    map.RowSize = exploredSquares.GetLength(0);
        //    map.ColumnSize = exploredSquares.GetLength(1);
        //    for (int i = 0; i < exploredSquares.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < exploredSquares.GetLength(1); j++)
        //        {
        //            if (exploredSquares[i,j] == '#')
        //            {
        //                map.walls.Add(new Wall(i, j)); //I detta fallet gör vi separata listor för alla olika typer av object, t ex om man inte vill att alla object skall ärva av en basklass som i exemplet under.
        //                //map.gameObjects.Add(new Wall(i,j)); // i detta fallet hade Wall ärvt utav GameObject, och gameObjects hade vart List<GameObject>
        //            }
        //        }
        //    }
        //    return map;
        //}
    }
}