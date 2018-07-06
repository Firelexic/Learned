using System;

namespace ConvertMethod
{
    class ConvertMethod
    {
        static void Main()
        {
            Console.WriteLine(Convert.ToBoolean(0.3));
            Console.WriteLine(Convert.ToBoolean(3));
            Console.WriteLine(Convert.ToBoolean(0));
            Console.WriteLine(Convert.ToBoolean(-1));

            Console.WriteLine(Convert.ToInt32("452"));
            Console.WriteLine(Convert.ToInt32(34.5));

        }
    }
}
