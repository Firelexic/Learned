using System;

namespace SumNumbers
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the n : ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;

            Console.Write("The sum 1");
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);
        }
    }
}
