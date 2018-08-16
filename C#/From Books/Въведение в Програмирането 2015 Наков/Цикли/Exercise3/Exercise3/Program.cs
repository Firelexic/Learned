using System;

namespace Exercise3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter how much number you want to add ? ");
            int n = int.Parse(Console.ReadLine());
            int high = int.MinValue;
            int low = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > high)
                {
                    high = num;
                }
                
                if (num < low)
                {
                    low = num;
                }

            }
            Console.WriteLine("MaxValue = {0}, MinValue = {1}",high,low);
        }
    }
}
