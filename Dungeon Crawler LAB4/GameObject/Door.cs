using System;

namespace DungeonCrawlerVersion61
{
    class Door : GameObject
    {
        private const string Symbol = "D";

        public Door(int h, int v) : base(h, v)
        {

        }
        public override string GetSymbol()
        {
            return Symbol;
        }
        //public override void TryOpenDoor(Position pos, Player player)
        //{
        //    if (pos.Horizontal == 2 && pos.Vertical == 3 && player.normalKey == true || pos.Horizontal == 7 && pos.Vertical == 4 && player.normalKey == true)
        //    {
        //        Console.WriteLine("You opened the door");
        //        Console.ReadKey();
        //        player.normalKey = false;
        //    }
        //    else if (pos.Horizontal == 6 && pos.Vertical == 8 && player.redKey == true)
        //    {
        //        Console.WriteLine("You opened the door");
        //        Console.ReadKey();
        //        player.redKey = false;
        //        //gameObjects.Remove(gameObject);
        //    }
        //    else if (pos.Horizontal == 10 && pos.Vertical == 9 && player.blueKey == true)
        //    {
        //        Console.WriteLine("You opened the door");
        //        Console.ReadKey();
        //        player.blueKey = false;
        //        //gameObjects.Remove(gameObject);
        //    }
        //    else
        //    {
        //        Console.WriteLine("The door is locked. Go and find a key to open it");
        //        Console.ReadKey();
        //        //return true;
        //    }
        //}
    }
}

