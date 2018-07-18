using System;

namespace ForLoop
{
    public class StartUp
    {
        public static void Main()
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Loop iteration : " + i);
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine($"Inner Loop Iteration : {j}");
                }
            }
        }
    }
}
