using System;

namespace LogicalOperators
{
    class LogicalOperators
    {
        static void Main()
        {
            int x = 3;
            int y = 8;

            Console.WriteLine(x == y);
            Console.WriteLine(y > x);

            if (y > x)
            {
                Console.WriteLine("y is greater than x");
            }
        }
    }
}
