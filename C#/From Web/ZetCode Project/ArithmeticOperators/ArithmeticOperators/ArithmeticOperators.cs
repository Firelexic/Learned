using System;

namespace ArithmeticOperators
{
    class ArithmeticOperators
    {
        static void Main()
        {
            int a = 10;
            int b = 11;
            int c = 12;

            int add = a + b + c;
            int sb = c - a;
            int mult = a * b;
            int div = c / 3;
            int rem = c % a;

            Console.WriteLine(add);
            Console.WriteLine(sb);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine(rem);
        }
    }
}
