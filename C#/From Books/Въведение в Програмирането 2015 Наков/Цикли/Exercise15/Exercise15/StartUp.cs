using System;

namespace Exercise15
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter decimal number: ");
            string n = Console.ReadLine();
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 16), 10);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
