using System;

namespace Exercise1
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Number = {0}",i);
            }
        }
    }
}
