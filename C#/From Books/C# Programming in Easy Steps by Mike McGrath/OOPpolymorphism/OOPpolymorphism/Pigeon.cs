using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpolymorphism
{
    public class Pigeon : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Pigeon Says : Coo ! Coo !");
        }

        public override void fly()
        {
            Console.WriteLine("A pigeon Flies Away..");
            base.fly();
        }
    }
}
