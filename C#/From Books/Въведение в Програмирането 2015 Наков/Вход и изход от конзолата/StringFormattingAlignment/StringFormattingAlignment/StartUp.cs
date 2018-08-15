using System;

namespace StringFormattingAlignment
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("{0,6}",123);
            Console.WriteLine("{0,-6}",123);
            Console.WriteLine("{0,6}",1234);
            Console.WriteLine("{0,-6}",1234);
            Console.WriteLine("{0,6}",12);
            Console.WriteLine("{0,-6}",12);
        }
    }
}
