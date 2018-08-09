using System;

namespace LogicalOperators
{
    public class StartUp
    {
        public static void Main()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine((5 > 7) ^ (a == b));
        }
    }
}
