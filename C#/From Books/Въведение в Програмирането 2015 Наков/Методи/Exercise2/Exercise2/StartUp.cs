using System;

namespace Exercise2
{
    public class StartUp
    {
        public static int GetMax(int number1,int number2)
        {
            int max = number1;
            if (number2 > number1)
            {
                max = number2;
            }
            return max;
        }

        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int bigger = Math.Max(number2, number3);

            Console.WriteLine("Biggest = {0}",Math.Max(number1,bigger));

        }
    }
}
