using System;

namespace MethodsEnum
{
    public class StartUp
    {
        public static void Main()
        {
            double x = 5;
            double y = 4;
            Console.WriteLine(GetSum(x, y));

            int solution;

            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}",solution);
        }

        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;

            return x + y;
        }

        static void DoubleIt(int x,out int solution)
        {
            solution = x * 2;
        }
    }
}
