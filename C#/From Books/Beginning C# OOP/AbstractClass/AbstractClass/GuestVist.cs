using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class GuestVist
    {
        public void GuestWelcomeMessage()
        {
            Console.WriteLine("Welcome to our Abstract Home");
        }

        public void GuestName()
        {
            Console.WriteLine("Guest name is : Abstract");
        }

        public abstract void PurposeOfVisit();
    }
}
