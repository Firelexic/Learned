using System;

namespace ComparisonOperators
{
    public class StartUp
    {
        public static void Main()
        {
            int nil = 0;
            int num = 0;
            int max = 0;
            char cap = 'A';
            char low = 'a';

            Console.WriteLine("Equality: ");
            Console.WriteLine("(0 == 0) : " + (nil == num));
            Console.WriteLine("(A == a) : " + (cap == low));

            Console.WriteLine("Inequality : ");
            Console.WriteLine("(0 != 1) : " + (nil > max));

            Console.WriteLine("Greater: ");
            Console.WriteLine("0 > 1" + (nil > max));

            Console.WriteLine("Less : ");
            Console.WriteLine("(0 < 1) " + (nil < max));

            Console.WriteLine("Greater/Equal : ");
            Console.WriteLine("(0 >= 0 ) " + (nil >= num));

            Console.WriteLine("Less or Equal: ");
            Console.WriteLine("(1 <= 0" + (max <= nil));
        }
    }
}
