using System;
using System.Collections.Generic;
using System.Text;

namespace DifferenceOverridingAndHidding
{
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }
}
