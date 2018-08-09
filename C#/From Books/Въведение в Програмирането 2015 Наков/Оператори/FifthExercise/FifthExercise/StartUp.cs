using System;

namespace FifthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (a + b) / 2 * h;
            Console.WriteLine("Area = {0} ",area);
        }
    }
}
