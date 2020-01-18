using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public List<Customer> customers;
        public int day;
        public double dayEarnings;
        public double dayProfit;

        public Day(int day)
        {
            day = 1;
            weather = new Weather();
            customers = new List<Customer>();

        }

    }
}