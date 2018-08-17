using System;

namespace Exercise8
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to binary is {1}.",
                hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
        }
    }
}
