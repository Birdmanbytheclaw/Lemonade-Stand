using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lemonade Stand!");

            //Inventory inventory = new Inventory();
            //inventory.MakePitcher();
            Weather weather = new Weather();
            weather.ChooseCondition();
            Console.WriteLine(weather.temperature + " " + weather.condition);
            Console.ReadLine();

           
        }
    }
}
