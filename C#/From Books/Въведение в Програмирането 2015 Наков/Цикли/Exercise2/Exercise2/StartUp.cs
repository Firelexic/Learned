using System;

namespace Exercise2
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % (3*7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
