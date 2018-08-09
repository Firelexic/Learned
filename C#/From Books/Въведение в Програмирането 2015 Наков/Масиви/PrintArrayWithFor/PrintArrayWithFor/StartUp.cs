using System;

namespace PrintArrayWithFor
{
    public class StartUp
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Output : ");
            for (int index = 0; index < array.Length; index++)
            {
                //Doubling the number
                array[index] = 2 * array[index];
                //Print the number
                Console.WriteLine(array[index]);
            }
        }
    }
}
