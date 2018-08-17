using System;

namespace Exercise7
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.",
                hexa, Convert.ToInt32(hexa, 16));
        }
    }
}
