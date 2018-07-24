using System;

namespace ForLoopTwoExam
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Sequence numbers from 1 to 10 : ");
            for (int i = 1; i <= 15; i++)
            {
                if (i > 10)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
