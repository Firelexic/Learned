using System;

namespace ThirteenExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int n = 350;
            int v = 0;
            int p = 3;
            n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine(n);
        }
    }
}
