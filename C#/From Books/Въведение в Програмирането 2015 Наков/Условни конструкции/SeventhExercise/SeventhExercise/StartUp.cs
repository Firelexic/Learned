using System;

namespace SeventhExercise
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter 5 numbers");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            int biggestNumber = 0;
            int maxOne = Math.Max(number1, number2);
            int maxTwo = Math.Max(number3, number4);
            int max = Math.Max(maxOne, maxTwo);

            if (max > number5)
            {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine(number5);
            }
        }
    }
}
