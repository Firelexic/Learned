using System;

namespace FifthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = number2 - number1;

            for (int i = number1; i <= number2; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("{0} is right number",i);
                }
            }
        }
    }
}
