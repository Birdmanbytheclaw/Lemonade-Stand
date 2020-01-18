﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Inventory
    {
        Recipe recipeForPitcher = new Recipe();

        public static List<Lemon> lemons;
        public static List<SugarCube> sugarCubes;
        public static List<IceCube> iceCubes;
        public static List<Cup> cups;
        
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

        //Recipe for Pitcher, Items it takes to make a Pitcher and remove those Items from Inventory when used to make a Pitcher
        public void MakePitcher()
        {
            string makePitcherResponse = Console.ReadLine();
            if (makePitcherResponse == "yes")
            {
                if (lemons.Count() >= recipeForPitcher.amountOfLemons && sugarCubes.Count() >= recipeForPitcher.amountOfSugarCubes && iceCubes.Count() >= recipeForPitcher.amountOfIceCubes)
                {
                    for(int i = 0; i >= lemons.Count(); i++)
                    {
                        lemons.RemoveAt(i);
                    }

                    for (int i = 0; i >= sugarCubes.Count(); i++)
                    {
                        sugarCubes.RemoveAt(i);
                    }

                    for(int i = 0; i >= iceCubes.Count(); i++)
                    {
                        iceCubes.RemoveAt(i);
                    }
                    //might need to add count for pitcher or cups of lemonade
                }
            }
            else
            {
                Console.WriteLine("You do not have enough product!");
            }

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


