using System;

namespace SystemEnvironmentClass
{
    public class Program
    {
        public static void Main()
        {
            int sum = 0;
            int startTime = Environment.TickCount;
            //The code fragment to be tested
            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }
            int endTime = Environment.TickCount;
            Console.WriteLine("The time elapsed is {0} sec.",(endTime - startTime) / 1000.0);
        }
    }
}
