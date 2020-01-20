using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        Day day = new Day();
        Store store = new Store();
        private Player player = new Player();
        private List<Day> days;
        private int currentDay;

        public Game()
        {
            days = new List<Day>() {new Day() };
            
        }

        public int daysToBePlayed()
        {

            return 1;
        }

        public void dayAndWeather()
        {
            Console.WriteLine( day.weather.temperature);
            Console.WriteLine(day.weather.condition);
        }

        public void customersInGame()
        {

        }

        public void useStore()
        {
            

        }

        public void playGame()
        {
            UserInterface.Greeting();
            UserInterface.SetPlayerName();

        }
    }
}
