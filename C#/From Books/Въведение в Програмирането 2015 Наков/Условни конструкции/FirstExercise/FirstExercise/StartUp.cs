using System;

namespace FirstExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int change = 0;

            if (number1 == number2)
            {
                Console.WriteLine("They are equal");
            }
            else if (number1 > number2)
            {
                change = number2;
                number2 = number1;
                number1 = change;
                Console.WriteLine("Now first number is {0} and second number is {1}",number1,number2);
            }
            else
            {
                change = number2;
                number2 = number1;
                number1 = change;
                Console.WriteLine("Now first number is {0} and second number is {1}", number1, number2);
            }
            
        }
    }
}
