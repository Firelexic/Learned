using System;

namespace WhileLoopOne
{
    public class StartUp
    {
       public  static void Main()
        {
            int k = 1;
            Console.WriteLine("The sequence numbers from 1 to 10 are :");
            while (k <= 10)
            {
                Console.WriteLine(k);
                k++;
            }
        }
    }
}
