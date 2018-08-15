using System;

namespace IfStatement
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter two numbers : ");
            Console.WriteLine("Enter first number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            int biggerNumber = firstNumber;
            if (secondNumber > firstNumber)
            {
                biggerNumber = secondNumber;
            }
            Console.WriteLine("The bigger number is : {0}",biggerNumber);
        }
    }
}
