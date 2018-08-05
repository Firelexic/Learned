using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Calculator
    {
        public static bool AreEqual<T>(T valueOne,T valueTwo)
        {
            return valueOne.Equals(valueTwo);
        }
    }
}
