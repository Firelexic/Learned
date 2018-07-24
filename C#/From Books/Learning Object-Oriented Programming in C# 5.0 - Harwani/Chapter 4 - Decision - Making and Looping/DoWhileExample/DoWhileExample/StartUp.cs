using System;

namespace DoWhileExample
{
    public class StartUp
    {
        public static void Main()
        {
            int k, s;
            s = 0;
            Console.WriteLine("Enter the number you wish to add, enter 0 to quit:");
            do
            {
                k = Convert.ToInt32(Console.ReadLine());
                s += k;
            } while (k != 0);
            Console.WriteLine("The sum of the numbers entered is {0}",s);
        }
    }
}
