using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static void Greeting()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Attempt to sell as many cups of lemonade as possible in 7 days.");
        }

        //Displays amount of each item in inventory -- Had to add using.System.Linq to use count method.
        //public static void CurrentInventory(Inventory lemons)
        //{
        //    Console.WriteLine("Current Inventory:");
        //    Console.WriteLine($"You have {lemons.Count()} Lemons.");
        //    Console.WriteLine($"You have {sugarCubes.Count()} Sugar Cubes.");
        //    Console.WriteLine($"You have {iceCubes.Count()} Ice Cubes.");
        //    Console.WriteLine($"You have {cups.Count()} Cups.");

        //    Console.Write("Press Enter to continue... ");
        //    Console.ReadLine();
        //    Console.Clear();
        //}

        public static void PitcherRecipe()
        {
            Console.WriteLine($"8 Lemons, 12 Sugar Cubes, 4 Ice Cubes, eqaul 1 Pitcher.");
        }

        public static void MakePitcher()
        {
            Console.WriteLine("Would you like to make a pitcher of lemonade?");
            Console.WriteLine("Type yes to make pitcher or no to continue");
        }
    }
}
