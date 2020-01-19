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

        public Day()
        {
            day = 1;
            weather = new Weather();
            customers = new List<Customer>();

        }

    }
}