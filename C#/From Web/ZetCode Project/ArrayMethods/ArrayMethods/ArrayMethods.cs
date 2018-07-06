using System;

namespace ArrayMethods
{
    class ArrayMethods
    {
        static void Main()
        {
            string[] names = { "Jane", "Frank", "Alice", "Tom" };

            Array.Sort(names);

            foreach (string element in names)
            {
                Console.WriteLine(element + ' ');
            }

            Console.WriteLine("\n");

            Array.Reverse(names);

            foreach (string element in names)
            {
                Console.WriteLine(element);
            }
        }
    }
}
