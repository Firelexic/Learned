using System;

namespace EighthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y : ");
            int y = int.Parse(Console.ReadLine());

            bool isInside = x * x + y * y <= 5;
            if (isInside)
            {
                Console.WriteLine("The point is inside ");
            }
        }
    }
}
