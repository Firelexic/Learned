using System;

namespace Exercise10
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter N: (N < 20) ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i + n -1; j++)
                {
                    Console.Write("|{0}|", j);
                }
                Console.WriteLine();
            }
        }
    }
}
