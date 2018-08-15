using System;

namespace CustomNumericFormats
{
    public class StartUp
    {
        public static void Main()
        {
            
            Console.WriteLine("{0:0.00}",1);
            Console.WriteLine("{0:#.##}",0.234);
            Console.WriteLine("{0:#####}",12345.67);
            Console.WriteLine("{0:(0#) ## ## ##",29342525);
            Console.WriteLine("{0:%##}",0.234);
        }
    }
}
