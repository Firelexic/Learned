using System;

namespace ImplicitTypeCast
{
    class ImplicitTypeCast
    {
        static void Main()
        {
            int numberOne = 0;
            byte numberTwo = 15;

            numberOne = numberTwo;

            Console.WriteLine(numberOne.GetType());
            Console.WriteLine(numberTwo.GetType());

            Console.WriteLine(12 + 12.5);
            Console.WriteLine("12" + 12);
        }
    }
}
