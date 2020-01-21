using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static string name;

        public static string Name { get { return name; } set { name = value; } }

        public static void Greeting()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Attempt to sell as many cups of lemonade as possible in 7 days.");
        }

        public static void SetPlayerName()
        {
            Console.Write("Enter a name for your player: ");
            name = Console.ReadLine();     
        }

        //public void StoreDisplay()
        //{
        //    bool buyProduct;
        //    int num = 0;
        //    Console.WriteLine("Lemonade Stand Store");
        //    Console.WriteLine( "You Have: ");
        //    Console.WriteLine(Inventory.lemons.Count + " lemons.       Press 1 to buy more Lemons.");
        //    Console.WriteLine( Inventory.sugarCubes.Count + " Sugar Cubes.  Press 2 to buy more Sugar Cubes.");
        //    Console.WriteLine(Inventory.iceCubes.Count + " Ice Cubes.    Press 3 to buy more Ice Cubes.");
        //    Console.WriteLine(Inventory.cups.Count + " Cups.         Press 4 to buy more Cups");
        //    Console.WriteLine("!Press 8 to leave the store!");
        //    buyProduct = int.TryParse(Console.ReadLine(), out num);
        //}



        public static void PitcherRecipe()
        {
            Console.WriteLine("8 Lemons, 12 Sugar Cubes, 4 Ice Cubes, eqaul 1 Pitcher.");
        }

        public static string MakePitcherPrompt()
        {
            Console.WriteLine("Would you like to make a pitcher of lemonade?");
            Console.WriteLine("Type yes to make pitcher or no to continue");
            string makePitcherResponse = Console.ReadLine();

            return makePitcherResponse;
        }
    }
}
