using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpolymorphism
{
    public class Bird
    {
        public virtual void talk()
        {
            Console.WriteLine("A Bird Talks..");
        }

        public virtual void fly()
        {
            Console.WriteLine("A Bird Flies..");
        }
    }
}
