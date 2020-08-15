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
            displayCompanyName();
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} had {food} for lunch!");

        }

        public void eat(List<Buddy> companions)
        {
            companions.AddRange(companions);

        }


    }
}
