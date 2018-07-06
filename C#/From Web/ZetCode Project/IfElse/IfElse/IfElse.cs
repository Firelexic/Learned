using System;

namespace IfElse
{
    class IfElse
    {
        static void Main()
        {
            Random r = new Random();
            int n = r.Next(-5, 5);
            Console.WriteLine(n);

            if (n < 0)
            {
                Console.WriteLine("The n variable is negative");
            }
            else if (n == 0)
            {
                Console.WriteLine("the n variable is zero");
            }
            else
            {
                Console.WriteLine("The n variable is positive");
            }
        }
    }
}
