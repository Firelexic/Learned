using System;

namespace Exercise13
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter binary number: ");
            string n = Console.ReadLine();
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
