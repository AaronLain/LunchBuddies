using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Restaurants
{
    class Restaurant
    {
        public Type Name { get; set; }

        private List<string> RestaurantNames = new List<string>();

        public void addNames()
        {
            RestaurantNames.AddRange(new List<string>
            {
                "Shoney's",
                "Waffle House",
                "Souper Salad",
                "Mr. Gatti's",
                "CiCi's Pizza",
                "Logan's Roadhouse",
                "Longhorn Steakhouse",
                "Chili's",
                "TGI Friday's",
                "O'Charley's"
            });
        }

        private readonly Random _random = new Random();
        public Restaurant()
        {
            this.addNames();
        }

        public void displayName()
        {
            int rand = _random.Next(RestaurantNames.Count);

            Console.WriteLine($"{RestaurantNames[rand]}");
        }

    }

}
