using System;

namespace RecursionExample
{
    public class StartUp
    {
        public static long Fib(int number)
        {
            if (number <= 2)
            {
                return 1;
            }
            return Fib(number - 1) + Fib(number - 2);
        }

        public static void Main()
        {
            long number = Fib(20);
            Console.WriteLine(number);
        }
    }
}
