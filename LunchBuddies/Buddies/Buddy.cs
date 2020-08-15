using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Buddies 
{
    class Buddy : Restaurants.Restaurant
    {
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Buddy(string firstName, string lastname)
        {
            FirstName = firstName;
            LastName = lastname;
        }

        public void eat()
        {
            changeCompanyName();
            Console.WriteLine($"{FirstName} {LastName} is at {RestaurantName}\r\n");
            
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} had {food} for lunch!\r\n");
        }

        public void eat(List<Buddy> companions)
        {
            changeCompanyName();

            Console.WriteLine($"{FirstName} {LastName} is at {RestaurantName} with: ");
           
            foreach (var i in companions)
            {
                if (i != this)
                {
                    Console.WriteLine($" - {i.FirstName}");
                }
            }
            
            Console.WriteLine();

        }

        public void eat(string food, List<Buddy> companions)
        {
            changeCompanyName();

            Console.WriteLine($"{FirstName} {LastName} is eating {food} at {RestaurantName} with: ");

            foreach (var i in companions)
            {
                if (i != this)
                {
                    Console.WriteLine($" - {i.FirstName}");
                }
                
            }
            
            Console.WriteLine();
        }


    }
}
