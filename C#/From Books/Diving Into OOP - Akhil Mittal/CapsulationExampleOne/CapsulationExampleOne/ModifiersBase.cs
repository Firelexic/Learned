using System;
using System.Collections.Generic;
using System.Text;

namespace CapsulationExampleOne
{
    public class ModifiersBase
    {
        static void AAA()
        {
            Console.WriteLine("ModifiersBase AAA");
        }

        public static void BBB()
        {
            Console.WriteLine("ModifiersBase BBB");
        }

        protected static void CCC()
        {
            Console.WriteLine("ModifiersBase CCC");
        }
    }
}
