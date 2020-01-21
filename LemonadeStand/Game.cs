using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        Day day;
        Store store;
        private Player player;
        private List<Day> days;
        private int currentDay;
        private int numberOfPitchers;
        private int storeLoop;

        public Game()
        {
            days = new List<Day>() {new Day() };
            day = new Day();
            store = new Store();
            player = new Player();
            
        }

        //public int daysToBePlayed()
        //{

        //    return 1;
        //}

        public void dayAndWeather()
        {
            Console.WriteLine("Weather for today is: " + day.weather.condition + " and " + day.weather.temperature + ".");
        }

        public void customersBuyLemonade()
        {

        }

        public void useStore()
        {
            store.BuyLemons();
            store.BuySugarCubes();
            store.BuyIceCubes();
            store.BuyCups();

        }

        public void playGame()
        {
            
            UserInterface.Greeting();
            UserInterface.SetPlayerName();
            day.weather.SetWeatherCondition();
            dayAndWeather();
            day.spawnCustomers();
            while(storeLoop != 8)
            {
                storeLoop = UserInterface.StoreDisplay();
                if (storeLoop == 1)
                {
                    store.BuyLemons();
                    player.wallet.Money -= store.price;
                }
                else if(storeLoop == 2)
                {
                    store.BuySugarCubes();
                }
                else if(storeLoop == 3)
                {
                    store.BuyIceCubes();
                }
                else if(storeLoop == 4)
                {
                    store.BuyCups();
                }
                player.wallet.CheckWalletBalance();
            }
            


        }
    }
}
