using System;

namespace MethodOverloading
{
    public class StartUp
    {
        public static void Add(int firstNumber,int secondNumber)
        {
            Console.WriteLine("Sum = {0} ",firstNumber + secondNumber);
        }

        public static void Add(int firstNumber,int secondNumber,int thirdNumber)
        {
            Console.WriteLine("Sum = {0}",firstNumber + secondNumber + thirdNumber);
        }

        public static void Main()
        {
            Add(3, 4, 5);
            Add(4, 5);
        }


    }
}
