using System;

namespace Exercise4
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} to binary is {1}.",
                deci, deci.ToString("deci"));
        }
    }
}
