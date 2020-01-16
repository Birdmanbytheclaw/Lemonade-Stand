using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Wallet
    {
        private double money = 0.00;
        public double Money;

        public Wallet(double Money)
        {
            this.Money = Money;
        }

        //For checing balance while making purchases in store --- Will most likely ajust if statement check at a later time
        public void CheckWalletBalance()
        {
            if(Money <= 0)
            {
                Console.WriteLine("You are out of Money!");
            }
            else
            {
                Console.WriteLine($"You have ${Money} left.");
            }
        }
    }
}
