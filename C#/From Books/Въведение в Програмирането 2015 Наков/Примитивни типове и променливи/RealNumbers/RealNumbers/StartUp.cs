using System;

namespace RealNumbers
{
    public class StartUp
    {
        static void Main()
        {
            float floatPi = 3.14f;
            Console.WriteLine(floatPi);
            double doublePi = 3.14;
            Console.WriteLine(doublePi);
            double nan = double.NaN;
            Console.WriteLine(nan);
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity);
        }
    }
}
