using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Buddies
{
    class Buddy
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public Buddy(string firstName, string lastname)
        {
            FirstName = firstName;
            LastName = lastname;
        }
    }
}
