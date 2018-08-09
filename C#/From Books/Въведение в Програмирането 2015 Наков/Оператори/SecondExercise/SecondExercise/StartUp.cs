using System;

namespace SecondExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isDivide = (number % 5 == 0) && (number % 7 == 0);
            if (isDivide)
            {
                Console.WriteLine("Divide on 5 and 7 ");
            }
            else
            {
                Console.WriteLine("Didn't divide on 5 and 7");
            }
        }
    }
}
