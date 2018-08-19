using System;

namespace CalculateSum
{
    public class StartUp
    {
        public static long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;
        }

        public static void Main()
        {
            long sum = CalcSum(2, 5);
            Console.WriteLine(sum);

            long sum2 = CalcSum(4, 0, -2, 12);
            Console.WriteLine(sum2);

            long sum3 = CalcSum();
            Console.WriteLine(sum3);
        }
    }
}
