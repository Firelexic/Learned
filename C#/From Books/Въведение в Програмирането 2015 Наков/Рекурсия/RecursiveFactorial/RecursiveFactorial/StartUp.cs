using System;

namespace RecursiveFactorial
{
    public class StartUp
    {
        public static decimal Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        public static void Main()
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());

            decimal factorial = Factorial(n);
            Console.WriteLine("{0}! = {1}",n,factorial);
        }
    }
}
