using System;

namespace Precedence
{
    public class StartUp
    {
        public static void Main()
        {
            int sum;
            sum = 1 + 4 * 3;
            Console.WriteLine("Default Order : " + sum);
            sum = (1 + 4) * 3;
            Console.WriteLine($"Forced Order {sum}");
            sum = 7 - 4 + 2;
            Console.WriteLine("Default Direction : " + sum);
            sum = 7 - (4 + 2);
            Console.WriteLine($"Forced Firection : {sum}");
        }
    }
}
