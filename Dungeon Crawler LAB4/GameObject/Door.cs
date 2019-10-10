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

        //public override void DoorAction(Player player, Map map)
        //{
        //    //var gameObject = map.gameObjects.Where(go => go.horizontal == player.position.Horizontal && go.vertical == player.position.Vertical).FirstOrDefault();
        //
        //    if (player.position.Horizontal == 2 && player.position.Vertical == 3 && player.normalKey == true || player.position.Horizontal == 7 && player.position.Vertical == 4 && player.normalKey == true)
        //    {
        //        Console.WriteLine("You opened the door");
        //        Console.ReadKey();
        //        player.normalKey = false;
        //        map.gameObjects.Remove(gameObject);
        //    }
        //    else if (player.position.Horizontal == 6 && player.position.Vertical == 8 && player.redKey == true)
        //    {
        //        Console.WriteLine("You opened the door");
        //        Console.ReadKey();
        //        player.redKey = false;
        //        map.gameObjects.Remove(gameObject);
        //    }
        //    else if (player.position.Horizontal == 10 && player.position.Vertical == 9 && player.blueKey == true)
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
        //
        //    }
        //}
    }
}

