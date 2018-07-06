using System;

namespace FloatDoubleInexact
{
    class FloatDoubleInexact
    {
        static void Main()
        {
            float numberOne = (float)1 / 3;
            double numberTwo = (double)1 / 3;

            if (numberOne == numberTwo)
            {
                Console.WriteLine("Number are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }
        }
    }
}
