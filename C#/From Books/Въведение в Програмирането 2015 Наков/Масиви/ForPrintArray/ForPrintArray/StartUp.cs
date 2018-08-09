using System;

namespace ForPrintArray
{
    public class StartUp
    {
        public static void Main()
        {
            string[] array = { "one", "two", "three", "four" };
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine("Element[{0}] = {1}",index,array[index]);
            }
        }
    }
}
