﻿namespace DungeonCrawlerVersion61
{
    internal class ValidMovement
    {
        public bool IsMovementValid(char movementDirection, int playerPositionHorizontal, int playerPositionVertical, char[,] map)
        {
            switch (movementDirection)
            {
                case 'W':
                    if (map[playerPositionVertical - 1, playerPositionHorizontal] == '#')
                    {
                        return false;
                    }
                    else
                        return true;
                case 'S':
                    if (map[playerPositionVertical + 1, playerPositionHorizontal] == '#')
                    {
                        return false;
                    }
                    else
                        return true;
                case 'A':
                    if (map[playerPositionVertical, playerPositionHorizontal - 1] == '#')
                    {
                        return false;
                    }
                    else
                        return true;
                case 'D':
                    if (map[playerPositionVertical, playerPositionHorizontal + 1] == '#')
                    {
                        return false;
                    }
                    else
                        return true;
                default:
                    
                    return false;
            }
        }

    }

    //if (validMovement.IsMovementValid(inputDirection, player.Position, map.Map))
    //{
    //player.PlayerMove(inputDirection); // change player position in player class
    //}
    //else
}