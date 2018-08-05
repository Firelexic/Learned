using System;

namespace Generics
{
    public class StartUp
    {
        public static void Main()
        {
            bool isEqual = Calculator.AreEqual(1, 2);

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("No Equal");
            }
        }
    }
}
