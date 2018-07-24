using System;

namespace DoWhile
{
    public class StartUp
    {
        public static void Main()
        {
            int k;
            Console.WriteLine("The sequence numbers from 1 to 10 are :");
            k = 1;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 10);
        }
    }
}
