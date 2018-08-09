using System;

namespace SymmetricalsArrays
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the values of the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;
            for (int index = 0; index < array.Length / 2; index++)
            {
                if (array[index] != array[n - index - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine("Is symmetric? {0}",symmetric);
        }
    }
}
