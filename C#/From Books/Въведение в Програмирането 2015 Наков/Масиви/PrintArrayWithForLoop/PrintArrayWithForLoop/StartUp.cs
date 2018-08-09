using System;

namespace PrintArrayWithForLoop
{
    public class StartUp
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Output");
            for (int index = 0; index < array.Length; index += 2)
            {
                array[index] = array[index] * array[index];
                Console.WriteLine(array[index]);
            }
        }
    }
}
