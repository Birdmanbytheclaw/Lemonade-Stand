﻿using System;
using System.Collections.Generic;
using System.Text;

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


    
    }


}


