using LunchBuddies.Buddies;
using LunchBuddies.Restaurants;
using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var companions = new List<Buddy>();

            var chuck = new Buddy("Chuck", "Burger");

            var dennis = new Buddy("Dennis", "Schnitzel");

            var meg = new Buddy("Meg", "Bryan");

            var helen = new Buddy("Hellen", "Mirror");

            companions.Add(chuck);
            companions.Add(dennis);
            companions.Add(meg);
            companions.Add(helen);

            chuck.eat();
            dennis.eat("enchiladas");
            meg.eat(companions);
            helen.eat("escargot", companions);
        }
    }
}
