using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Store
    {
        private double pricePerLemon;
        static double lemonsPurchased = double.Parse(Console.ReadLine());

        private double pricePerSugarCube;
        static double SugarCubesPurchased = double.Parse(Console.ReadLine());

        private double pricePerIceCube;
        static double IceCubesPurchased = double.Parse(Console.ReadLine());

        private double pricePerCup;
        static double CupsPurchased = double.Parse(Console.ReadLine());

        Inventory inventory = new Inventory();

        public Store()
        {

        }

        public void BuyLemons()
        {
            if(lemonsPurchased == 10)
            {
                pricePerLemon = .76;
            }
            else if(lemonsPurchased == 30)
            {
                pricePerLemon = 2.08;
            }
            else if(lemonsPurchased == 75)
            {
                pricePerLemon = 4.17;
            }
            
        }

        public void BuySugarCubes()
        {
            if(SugarCubesPurchased == 8)
            {
                pricePerSugarCube = .53;
            }
            else if(SugarCubesPurchased == 20)
            {
                pricePerSugarCube = 1.64;
            }
            else if(SugarCubesPurchased == 40)
            {
                pricePerSugarCube = 3.28;
            }

        }

        public void BuyIceCubes()
        {
            if(IceCubesPurchased == 100)
            {
                pricePerIceCube = .97;
            }
            else if(IceCubesPurchased == 250)
            {
                pricePerIceCube = 2.15;
            }
            else if(IceCubesPurchased == 500)
            {
                pricePerIceCube = 3.60;
            }

        }

        public void BuyCups()
        {
            if(CupsPurchased == 25)
            {
                pricePerCup = .97;
            }
            else if(CupsPurchased == 50)
            {
                pricePerCup = 1.69;
            }
            else if(CupsPurchased == 100)
            {
                pricePerCup = 3.09;
            }
        }



    }
}
    
