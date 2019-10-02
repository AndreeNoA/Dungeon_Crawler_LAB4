namespace DungeonCrawlerVersion61
{
    internal class ValidMovement
    {
        public bool IsMovementValid(char movementDirection, int playerPositionHorizontal, int playerPositionVertical, char[,] map)
        {
            switch (movementDirection)
            {
                case 'W':
                    if (map[playerPositionHorizontal, playerPositionVertical - 1] == '#')
                    {
                        return false;
                    }
                    else
                        return true;
                case 'S':
                    if (map[playerPositionHorizontal, playerPositionVertical + 1] == '#')
                    {
                        return false;
                    }
                    else
                        return true;
                case 'A':
                    if (map[playerPositionHorizontal - 1, playerPositionVertical] == '#')
                    {
                        return false;
                    }
                    else
                        return true;
                case 'D':
                    if (map[playerPositionHorizontal + 1, playerPositionVertical] == '#')
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