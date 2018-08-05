using System;

namespace DifferenceOverridingAndHidding
{
    public class Program
    {
        public static void Main()
        {
            BaseClass B = new DerivedClass();
            B.Print();
        }
    }
}
