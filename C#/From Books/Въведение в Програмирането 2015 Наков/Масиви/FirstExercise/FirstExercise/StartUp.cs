using System;

namespace FirstExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int[] array = new int[20];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = 5 * index;
            }
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
