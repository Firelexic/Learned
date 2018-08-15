using System;

namespace SecondExercise
{
    public class StartUp
    {
        public static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            int counter = 0;

            if (number1 == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (number2 == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (number3 == 0)
            {
                Console.WriteLine("Zero");
            }

            if (number1 < 0)
            {
                counter++;
            }
            else if (number2 < 0)
            {
                counter++;
            }
            else if (number3 < 0)
            {
                counter++;
            }

            if (counter % 2 == 1)
            {
                Console.WriteLine("The expression is negative");
                Console.WriteLine("Expression : '-' ");
            }
            else
            {
                Console.WriteLine("The expression is positive");
                Console.WriteLine("Expression : '+'");
            }

           
        }
    }
}
