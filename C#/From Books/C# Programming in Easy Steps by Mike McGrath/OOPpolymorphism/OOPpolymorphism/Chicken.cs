using System;
using System.Collections.Generic;
using System.Text;

namespace OOPpolymorphism
{
    public class Chicken : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Chicken Says : Cluck ! Cluck !");
        }

        public override void fly()
        {
            Console.WriteLine("I'm A Chicken - I Can't Fly");
            base.fly();
        }
    }
}
