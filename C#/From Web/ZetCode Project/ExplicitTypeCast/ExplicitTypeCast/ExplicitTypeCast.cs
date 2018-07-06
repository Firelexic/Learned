using System;

namespace ExplicitTypeCast
{
    class ExplicitTypeCast
    {
        static void Main()
        {
            float a;
            double b = 13.5;
            int c;

            a = (float)b;
            c = (int)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
