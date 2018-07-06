using System;

namespace ContinueStatement
{
    class ContinueStatement
    {
        static void Main()
        {
            int num = 0;

            while (num < 1000)
            {
                num++;
                if ((num % 2 ) == 0)
                {
                    continue;
                }
                Console.WriteLine(num + ' ');
            }
            Console.WriteLine("\n");
        }
    }
}
