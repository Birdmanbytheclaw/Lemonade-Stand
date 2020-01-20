using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Store
    {
        Player player = new Player();
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
                player.wallet.Money -= pricePerLemon;
                for(int i = 0; i <= lemonsPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else if(lemonsPurchased == 30)
            {
                pricePerLemon = 2.08;
                player.wallet.Money -= pricePerLemon;
                for (int i = 0; i <= lemonsPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else if(lemonsPurchased == 75)
            {
                pricePerLemon = 4.17;
                player.wallet.Money -= pricePerLemon;
                for (int i = 0; i <= lemonsPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
            
        }

        public void BuySugarCubes()
        {
            if(SugarCubesPurchased == 8)
            {
                pricePerSugarCube = .53;
                player.wallet.Money -= pricePerSugarCube;
                for(int i = 0; i <= SugarCubesPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else if(SugarCubesPurchased == 20)
            {
                pricePerSugarCube = 1.64;
                player.wallet.Money -= pricePerSugarCube;
                for (int i = 0; i <= SugarCubesPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else if(SugarCubesPurchased == 40)
            {
                pricePerSugarCube = 3.28;
                player.wallet.Money -= pricePerSugarCube;
                for (int i = 0; i <= SugarCubesPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }

        }

        public void BuyIceCubes()
        {
            if(IceCubesPurchased == 100)
            {
                pricePerIceCube = .97;
                player.wallet.Money -= pricePerSugarCube;
                for(int i = 0; i <= IceCubesPurchased; i++)
                {
                    player.inventory.AddIceCubesToIceCubesList();
                }
            }
            else if(IceCubesPurchased == 250)
            {
                pricePerIceCube = 2.15;
                player.wallet.Money -= pricePerSugarCube;
                for (int i = 0; i <= IceCubesPurchased; i++)
                {
                    player.inventory.AddIceCubesToIceCubesList();
                }
            }
            else if(IceCubesPurchased == 500)
            {
                pricePerIceCube = 3.60;
                player.wallet.Money -= pricePerSugarCube;
                for (int i = 0; i <= IceCubesPurchased; i++)
                {
                    player.inventory.AddIceCubesToIceCubesList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }

        }

        public void BuyCups()
        {
            if(CupsPurchased == 25)
            {
                pricePerCup = .97;
                player.wallet.Money -= pricePerCup;
                for(int i = 0; i <= CupsPurchased; i++)
                {
                    player.inventory.AddCupToCupsList();
                }
            }
            else if(CupsPurchased == 50)
            {
                pricePerCup = 1.69;
                player.wallet.Money -= pricePerCup;
                for (int i = 0; i <= CupsPurchased; i++)
                {
                    player.inventory.AddCupToCupsList();
                }
            }
            else if(CupsPurchased == 100)
            {
                pricePerCup = 3.09;
                player.wallet.Money -= pricePerCup;
                for (int i = 0; i <= CupsPurchased; i++)
                {
                    player.inventory.AddCupToCupsList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }



    }
}
    
