using System;
using System.Collections.Generic;
using System.Text;

namespace Capsulation
{
    public class Modifiers
    {
        static void AAA()
        {
            Console.WriteLine("Modifiers AAA");
        }

        public static void BBB()
        {
            Console.WriteLine("Modifiers BBB");
            AAA();
        }
    }
}
