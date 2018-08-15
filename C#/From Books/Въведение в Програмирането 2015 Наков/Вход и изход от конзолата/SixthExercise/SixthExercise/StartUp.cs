using System;

namespace SixthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter first number ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} is greater then {1}",Math.Max(number1,number2),Math.Min(number1,number2));
        }
    }
}
