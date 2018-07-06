using System;

namespace IfElseStatement
{
    class IfElseStatement
    {
        static void Main()
        {
            Random random = new Random();
            int n = random.Next(-5, 5);
            Console.WriteLine(n);

            if (n > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
        }
    }
}
