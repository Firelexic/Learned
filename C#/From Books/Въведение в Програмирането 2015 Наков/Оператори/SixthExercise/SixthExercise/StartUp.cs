using System;

namespace SixthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b :");
            double b = double.Parse(Console.ReadLine());

            double area = a * b;
            double perimeter = (a + b) * 2;

            Console.WriteLine("Area = {0}",area);
            Console.WriteLine("Perimeter = {0}",perimeter);
        }
    }
}
