using System;

namespace CheckUnckeck
{
    public class StartUp
    {
        public static void Main()
        {
            int a = 2000000000;
            int b = 2000000000;
            // int c=2000000000 + 2000000000; //Displays compiler error - "operation
            //overflows"
            int c = a + b;
            Console.WriteLine("Value of c= {0}", c);
            Console.WriteLine("Unchecked - preventing overflow checking. Value of c={0}",
            unchecked(a + b));
            Console.WriteLine("Checked - checking overflow at run time. Value of c={0}",
            checked(a + b));
        }
    }
}
