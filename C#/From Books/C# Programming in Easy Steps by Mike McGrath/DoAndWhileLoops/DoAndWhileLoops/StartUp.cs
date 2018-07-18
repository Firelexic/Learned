using System;

namespace DoAndWhileLoops
{
    public class StartUp
    {
        public static void Main()
        {
            int[] nums = new int[10];
            int i = 0;

            while (i < nums.Length)
            {
                nums[i] = i;
                Console.Write($" | {nums[i]}");
                i++;
            }
            Console.WriteLine();

            do
            {
                i--;
                if (i == 8)
                {
                    Console.Write(" | Skipped");
                    continue;
                   
                }
                if (i == 3)
                {
                    Console.WriteLine(" | Done");
                    break;
                }


                
                Console.Write($" | {nums[i]}");
                
            } while (i > 0);
        }
    }
}
