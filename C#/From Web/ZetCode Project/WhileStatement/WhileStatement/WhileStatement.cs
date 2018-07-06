using System;

namespace WhileStatement
{
    class WhileStatement
    {
        static void Main()
        {
            int i = 0;
            int sum = 0;

            while (i < 10)
            {
                i++;
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
