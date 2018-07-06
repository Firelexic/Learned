using System;

namespace Arrays
{
    class Arrays
    {
        static void Main()
        {
            int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 2;
            numbers[2] = 1;
            numbers[3] = 5;
            numbers[4] = 6;

            int len = numbers.Length;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
