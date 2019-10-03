﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerVersion61
{
    public class Map
    {
        public char[,] squares = new char[10, 10] { {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                                                    {'#', 'S', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                                                    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}};

        public char[,] exploredSquares = new char[10, 10] { {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                                                            {'#', 'S', '#', ' ', ' ', ' ', ' ', 'M', 'C', '#'},
                                                            {'#', ' ', '#', ' ', '#', '#', 'D', '#', '#', '#'},
                                                            {'#', ' ', '#', ' ', '#', ' ', ' ', '#', ' ', 'E'},
                                                            {'#', ' ', 'D', ' ', '#', ' ', '#', 'C', ' ', '#'},
                                                            {'#', 'M', '#', '#', '#', ' ', '#', 'T', ' ', '#'},
                                                            {'#', 'C', '#', ' ', ' ', ' ', '#', ' ', ' ', '#'},
                                                            {'#', '#', '#', ' ', '#', '#', '#', ' ', 'T', '#'},
                                                            {'#', 'C', 'M', ' ', 'D', ' ', ' ', ' ', ' ', '#'},
                                                            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}};
    }
}