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

        //public override void TryOpenDoor(Player player)
        //{
        //    //Console.WriteLine(player.position.Horizontal); // 1
        //    //Console.WriteLine(player.position.Vertical); // 5
        //    //Console.ReadKey();
        //    //if ()
        //    //{
        //    //    Console.WriteLine("Normal door");
        //    //    Console.ReadKey();
        //    //}
        //    //if (player.normalKey == true)
        //    //{
        //    //    return true;
        //    //}
        //    //return false;
        //
        //}
    }
}
