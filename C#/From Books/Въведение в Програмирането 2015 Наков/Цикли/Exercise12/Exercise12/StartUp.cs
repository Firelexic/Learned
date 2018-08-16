using System;

namespace Exercise12
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Result is {0}", binary);
        }
    }
}
