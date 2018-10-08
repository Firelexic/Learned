using System;
using System.Collections.Generic;
using System.Text;

namespace ConstAndReadonlyExample
{
    public class ConstReadonlyModifiersTest
    {
        public const double PI = 3.141592653589793285;
        public readonly double size;

        public ConstReadonlyModifiersTest(int size)
        {
            this.size = size;
        }

        public static void Main()
        {
            Console.WriteLine(PI);
            Console.WriteLine(ConstReadonlyModifiersTest.PI);
            ConstReadonlyModifiersTest t = new ConstReadonlyModifiersTest(5);
            Console.WriteLine(t.size);
        }
    }
}
