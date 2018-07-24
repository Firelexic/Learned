using System;

namespace ArrayInitializing
{
    public class StartUp
    {
        public static void Main()
        {
            int[] p = { 4, 0, 2, 8, 1, 7, 3, 9, 5, 6 };
            Console.WriteLine("The numerals entered in the array are : ");
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
}
