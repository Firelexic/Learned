using System;

namespace ForLoopContinue
{
    public class StartUp
    {
        public static void Main()
        {
            
            Console.WriteLine("Sequence numbers from 1 to 10 except 7 : ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
