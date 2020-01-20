using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lemonade Stand!");

            Inventory inventory = new Inventory();
            inventory.MakePitcher();
            Console.ReadLine();

           
        }
    }
}
