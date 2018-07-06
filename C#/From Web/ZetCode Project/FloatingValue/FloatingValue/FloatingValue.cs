using System;

namespace FloatingValue
{
    class FloatingValue
    {
        static void Main(string[] args)
        {
            float numberOne = 1.234f;
            double numberTwo = 1.234;
            decimal numberThree = 1.234m;

            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);

            Console.WriteLine(numberOne.GetType());
            Console.WriteLine(numberTwo.GetType());
            Console.WriteLine(numberThree.GetType());
        }
    }
}
