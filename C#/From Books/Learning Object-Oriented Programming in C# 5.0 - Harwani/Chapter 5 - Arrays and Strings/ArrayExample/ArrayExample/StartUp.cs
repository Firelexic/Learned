using System;

namespace ArrayExample
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter how much elements you will input");
            int elements = int.Parse(Console.ReadLine());
            int[] p = new int[elements];
            for (int i = 0; i < p.Length ; i++)
            {
                Console.Write($"array[{i}] = ");
                p[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("The numbers entered in the array are : ");
            for (int i = 0; i < p.Length ; i++)
            {
                Console.WriteLine($"array[{i}] = {p[i]}");
                
            }
        }
    }
}
