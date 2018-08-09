using System;

namespace ThirdExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 100)
            {
                number = number / 10;
                number = number / 10;
                if (number == 7)
                {
                    Console.WriteLine("First number is 7");
                }
                else
                {
                    Console.WriteLine("First number isnt 7");
                }
            }
        }
    }
}
