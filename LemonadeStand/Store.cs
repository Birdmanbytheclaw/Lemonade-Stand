using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Store
    {
        private double pricePerLemon = .04;
        static double lemonsPurchased = int.Parse(Console.ReadLine());

        private double pricePerSugarCube = .05;
        static double SugarCubesPurchased = int.Parse(Console.ReadLine());

        private double pricePerIceCube = .009;
        static double IceCubesPurchased = int.Parse(Console.ReadLine());

        private double pricePerCup = .03;
        static double CupsPurchased = int.Parse(Console.ReadLine());

        Inventory inventory = new Inventory();

        public Store()
        {

        }

        public static void BuyLemons()
        {
            if(lemonsPurchased == 6)
            {
                
            }
            
        }

        public static void BuySugarCubes()
        {

        }

        public static void BuyIceCubes()
        {

        }

        public static void BuyCups()
        {

        }



    }
}
    
