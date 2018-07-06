using System;

namespace InitializingArrays
{
    class InitializingArrays
    {
        static void Main()
        {
            int[] arr = new int[] { 2, 3, 4, 5, 6, 7, 8 };
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
