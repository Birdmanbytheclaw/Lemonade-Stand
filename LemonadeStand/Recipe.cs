using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Recipe
    {
        Inventory inventoryForRecipe = new Inventory();

        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
            amountOfLemons = inventoryForRecipe.lemons.Count();
            amountOfSugarCubes = inventoryForRecipe.sugarCubes.Count();
            amountOfIceCubes = inventoryForRecipe.iceCubes.Count();
            pricePerCup = .25;
        }

        public void PitcherRecipe()
        {
            Console.WriteLine($"8 Lemons, 12 Sugar Cubes, 4 Ice Cubes, eqaul 1 Pitcher.");
        }

        

    }


}
