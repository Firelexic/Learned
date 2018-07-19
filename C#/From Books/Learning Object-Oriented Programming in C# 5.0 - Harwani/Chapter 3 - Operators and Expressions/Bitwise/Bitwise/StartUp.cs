using System;

namespace Bitwise
{
    public class StartUp
    {
        public static void Main()
        {
            int a, b, c, d, e, g, h;
            a = 10;
            b = 7;
            c = a & b;
            d = a ^ b;
            e = a | b;
            Console.WriteLine("The result of 10 and 7 operation is {0}", c);
            Console.WriteLine("The result of 10 exclusive or 7 operation is {0}", d);
            Console.WriteLine("The result of 10 or 7 operation is {0}", e);
            g = a << 2;
            Console.WriteLine("Left shifting - Multiplying 10 by 4 becomes: {0}", g);
            h = a >> 1;
            Console.WriteLine("Right shifting - Dividing 10 by 2 becomes: {0}", h);
            Console.WriteLine("The bitwise negation of {0} is {1}", a, ~a);
        }
    }
}
