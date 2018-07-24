using System;

namespace ArrayForEach
{
    public class StartUp
    {
        public static void Main()
        {
            int[] p = { 4, 0, 2, 8, 1, 7, 3, 9, 5, 6 };
            Console.WriteLine("The original order of numerals in the array is : ");
            foreach (int number in p)
            {
                Console.WriteLine(number);
            }
            Array.Sort(p);
            int[] sortedArray = p;
            Console.WriteLine("The array in sorted order is :");
            foreach (int element in sortedArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("P array ");
            foreach (var elemen in p)
            {
                Console.WriteLine(elemen);
            }
          
        }
    }
}
