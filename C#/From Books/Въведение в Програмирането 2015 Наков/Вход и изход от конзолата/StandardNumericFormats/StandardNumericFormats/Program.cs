using System;

namespace StandardNumericFormats
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("{0:C3}",123.456);
            Console.WriteLine("{0:D4}",-1234);
            Console.WriteLine("{0:E2}",123);
            Console.WriteLine("{0:F2}",-123.456);
            Console.WriteLine("{0:N2}",1234567.8);
            Console.WriteLine("{0:P}",0.456);
            Console.WriteLine("{0:X}",254);
        }
    }
}
