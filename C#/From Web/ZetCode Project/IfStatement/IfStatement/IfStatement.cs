using System;

namespace IfStatement
{
    class IfStatement
    {
        static void Main()
        {
            Random random = new Random();
            int n = random.Next(-5, 5);
            Console.WriteLine(n);
            if (n > 0)
            {
                Console.WriteLine("The variable is positive ");
            }
        }
    }
}
