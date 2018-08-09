using System;

namespace ArrayReversed
{
    public class StartUp
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Reversed : ");
            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}
