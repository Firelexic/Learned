using System;

namespace Exercise3
{
    public class StartUp
    {
        static void conversion(string value)
        {
            Console.WriteLine("{0} to decimal is {1}.",
                value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} to decimal is {1}.\n", value,
                Convert.ToString(Convert.ToInt32(value, 16), 2));
        }

        public static void Main()
        {
            conversion("2A3E");
            conversion("FA");
            conversion("FFFF");
            conversion("5A0E9");
        }
    }
}
