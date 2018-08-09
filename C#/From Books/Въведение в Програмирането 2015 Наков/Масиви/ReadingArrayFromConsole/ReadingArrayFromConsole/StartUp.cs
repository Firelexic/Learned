using System;

namespace ReadingArrayFromConsole
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
