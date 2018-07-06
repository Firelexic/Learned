using System;

namespace BreakStatement
{
    class BreakStatement
    {
        static void Main()
        {
            Random random = new Random();

            while (true)
            {
                int num = random.Next(1, 30);
                Console.Write(num + " ");

                if (num == 22)
                {
                    break;
                }
            }
            Console.WriteLine('\n');
        }
    }
}
