using System;

namespace BiggestNumber
{
    public class StartUp
    {
        public static void PrintMax(float number1,float number2)
        {
            float max = number1;
            if (number2 > number1)
            {
                max = number2;
            }
            Console.WriteLine("Max number : " + max);
        }

        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            PrintMax(number1, number2);
        }
    }
}
