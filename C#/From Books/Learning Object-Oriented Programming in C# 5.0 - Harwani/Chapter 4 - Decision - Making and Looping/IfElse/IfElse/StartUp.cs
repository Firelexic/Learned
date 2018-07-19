using System;

namespace IfElse
{
    public class StartUp
    {
        public static void Main()
        {
            int m;
            Console.WriteLine("Enter marks : ");
            m = Convert.ToInt32(Console.ReadLine());

            if (m >= 60)
            {
                Console.WriteLine("First Division");
            }
            else
            {
                Console.WriteLine("Second Division");
            }
        }
    }
}
