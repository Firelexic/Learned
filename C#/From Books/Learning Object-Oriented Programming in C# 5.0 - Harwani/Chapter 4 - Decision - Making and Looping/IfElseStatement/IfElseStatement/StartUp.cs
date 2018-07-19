using System;

namespace IfElseStatement
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
            else if (m >= 45)
            {
                Console.WriteLine("Second Division");
            }
            else
            {
                Console.WriteLine("Third Division");
            }
        }
    }
}
