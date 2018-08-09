using System;

namespace FirstExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
