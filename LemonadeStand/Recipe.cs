using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
            amountOfLemons = 10;
            amountOfSugarCubes = 5;
            amountOfIceCubes = 4;
            pricePerCup = .25;
        }

        public void PitchRecipe()
        {
            Console.WriteLine($"{amountOfLemons} Lemons, {amountOfSugarCubes} Sugar Cubes, {amountOfIceCubes} Ice Cubes, eqaul 1 Pitcher.");
        }

        

    }


}
