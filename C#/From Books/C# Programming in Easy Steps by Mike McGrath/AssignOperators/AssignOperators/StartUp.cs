using System;

namespace AssignOperators
{
    public class StartUp
    {
        public static void Main()
        {
            int a;
            int b;

            Console.WriteLine("Assign Values: ");
            Console.WriteLine("a = " + (a = 8));
            Console.WriteLine("b = " + (b = 4));

            Console.WriteLine("Add and Assign: ");
            Console.WriteLine("a += b(8+4) a = " + (a += b));

            Console.WriteLine("Subtract and Assign: ");
            Console.WriteLine("a -= b(12 -= 4) a = " + (a -= b));

            Console.WriteLine("Multiply and Assign: ");
            Console.WriteLine("a *= b (8 *= 4) a = " + (a *= b));

            Console.WriteLine("Divide and Assign: ");
            Console.WriteLine("a /= b (32 /= 4) a = " + (a /= b));

            Console.WriteLine("Modulus and Assign: ");
            Console.WriteLine("a %= b ( 8 %= 4 ) a = " + (a %= b));
        }
    }
}
