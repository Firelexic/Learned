using System;

namespace WhileLoopTwo
{
    public class StartUp
    {
        public static void Main()
        {
            char k;
            k = 'a';
            while (k <= 'z')
            {
                Console.WriteLine("{0}",k);
                k++;
            }
        }
    }
}
