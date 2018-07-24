using System;
using System.Collections.Generic;
using System.Text;

namespace CapsulationExampleOne
{
    public class ModifiersDerived : ModifiersBase
    {
        public static void XXX()
        {
            AAA();
            BBB();
            CCC();
        }
    }
}
