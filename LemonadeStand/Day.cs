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

        public Day() 
        {
            day = 1;
            weather = new Weather();
            Customer = new List<Customer>();
           
        }

    }
}
/* customers = new List<Customer>() {new Customer("Bobert"), 
new Customer("Lisa"), new Customer("Kenny"), new Customer("Slagathor"), new Customer("Deku"),
                new Customer("Saitama"), new Customer("Morty"), new Customer("Peter"), new Customer("Flynn"),
                new Customer("Guy"), new Customer("chad"), new Customer("tonithy"), new Customer("Stanley"),
                new Customer("Darwin"), new Customer("Derrick"), new Customer("Siri"), new Customer("Rick"),
                new Customer("Molly"), new Customer("Lilly"), new Customer("Tyrion"), new Customer("Light"),
                new Customer("Cortana"), new Customer("John"), new Customer("Diane"), new Customer("Susan"),
                new Customer("Zach"), new Customer("Nate"), new Customer("Max"), new Customer("sulamita"), new Customer("charles"), new Customer("Hellen"),
                new Customer("Mark"), new Customer("Reuben"), new Customer("Gill"), new Customer("bella"), new Customer("theresa"), new Customer("Zorn"),
                new Customer("Archer"), new Customer("Liz"), new Customer("Heather"), new Customer("Kevin"), new Customer("Parker"), new Customer("Adam"),
                };*/