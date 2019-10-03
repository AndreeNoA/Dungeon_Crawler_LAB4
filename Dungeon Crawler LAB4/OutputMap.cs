using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    internal class OutputMap : Map
    {
        //public void PrintMap(Map map)
        //{
        //    for (int i = 0; i < map.RowSize; i++)
        //    {
        //        for (int j = 0; j < map.ColumnSize; j++)
        //        {
        //            Console.Write(map.GetObjectAt(i, j).Symbol);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        public void PrintMap(int playerPositionHorizontal, int playerPositionVertical)
        {
            
            //Copying from explored map to show whats around the player
            squares[playerPositionVertical, playerPositionHorizontal - 1] = exploredSquares[playerPositionVertical, playerPositionHorizontal - 1];
            squares[playerPositionVertical - 1, playerPositionHorizontal] = exploredSquares[playerPositionVertical - 1, playerPositionHorizontal];
            squares[playerPositionVertical, playerPositionHorizontal + 1] = exploredSquares[playerPositionVertical, playerPositionHorizontal + 1];
            squares[playerPositionVertical + 1, playerPositionHorizontal] = exploredSquares[playerPositionVertical + 1, playerPositionHorizontal];

            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int k = 0; k < squares.GetLength(1); k++)
                {
                    if (playerPositionHorizontal == k && playerPositionVertical == i)
                    {
                        Console.Write("@");
                    }
                    else
                        Console.Write(squares[i, k]);


                }

                Console.WriteLine();
            }
        }
    }
}