using System;

namespace FourteenExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number = 72;
            bool isPrime = true;
            if (number > 2)
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
                {
                    if (number % i == 0) isPrime = false;
                }
            Console.WriteLine("{0} is prime?: {1}", number, isPrime);
        }
    }
}
