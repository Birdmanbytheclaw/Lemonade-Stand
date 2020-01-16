using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }

        public void ClearInventory()
        {
            lemons.Clear();
            sugarCubes.Clear();
            iceCubes.Clear();
            cups.Clear();
        }

        //Displays amount of each item in inventory -- Had to add using.System.Linq to use count method.
        public void CurrentInventory()
        {
            Console.WriteLine("Current Inventory:");
            Console.WriteLine($"You have {lemons.Count()} Lemons.");
            Console.WriteLine($"You have {sugarCubes.Count()} Sugar Cubes.");
            Console.WriteLine($"You have {iceCubes.Count()} Ice Cubes.");
            Console.WriteLine($"You have {cups.Count()} Cups.");

            Console.Write("Press Enter to continue... ");
            Console.ReadLine();
            Console.Clear();
        }

        //Need a counter for Cups sold
        public void InventorySold()
        {

        }

        //Recipe for Pitcher, Items it takes to make a Pitcher and remove those Items from Inventory when used to make a Pitcher
        public void RecipeForPitcher()
        {

        }

        public void AddLemonToLemonsList()
        {
            lemons.Add(new Lemon());
        }

        public void AddSugarCubeToSugarCubesList()
        {
            sugarCubes.Add(new SugarCube());
        }

        public void AddIceCubesToIceCubesList()
        {
            iceCubes.Add(new IceCube());
        }

        public void AddCupToCupsList()
        {
            cups.Add(new Cup());
        }



    }


}


