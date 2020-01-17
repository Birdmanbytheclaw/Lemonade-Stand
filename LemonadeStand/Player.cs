using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Inventory inventory = new Inventory();
        public Wallet wallet = new Wallet();
        public Recipe recipe ;
        public Pitcher pitcher;

        public Player()
        {

        }

        public static void NamePlayer()
        {

        }

    }
}
