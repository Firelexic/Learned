using System;

namespace TernaryOperator
{
    public class StartUp
    {
        public static void Main()
        {
            int a = 8;
            int b = 3;

            string verb = (a != 1) ? "are" : "is";
            Console.WriteLine($"There {verb} {a}");

            string parity = (a % 2 != 0) ? "Odd" : "Even";
            Console.WriteLine($"{a} is {parity}");

            parity = (b % 2 != 0) ? "Odd" : "Even";
            Console.WriteLine($"{b} is {parity}");

            int max = (a > b) ? a : b;
            Console.WriteLine($"Maximum is {max}");
        }
    }
}
