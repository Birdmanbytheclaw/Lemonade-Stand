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
