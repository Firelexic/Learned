using System;

namespace Cast
{
    class StartUp
    {
        static void Main()
        {
            double num = 10.5;
            int integer = 2;

            num = num + integer;
            Console.WriteLine($"Implicit Cast: {num}");

            num = (double) 7 / integer;
            Console.WriteLine($"Explicit Cast {num}");
        }
    }
}
