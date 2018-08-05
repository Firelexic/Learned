using System;

namespace Methods
{
    public class StartUp
    {
        public static void EvenNumbers(int index)
        {
            int start = 0;

            while (start <= index)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        public static void Main()
        {
            EvenNumbers(50);

        }
    }
}
