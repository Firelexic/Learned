using System;

namespace IfStatement
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number : ");
            int numberOne = int.Parse(Console.ReadLine());

            if (numberOne == 1)
            {
                Console.WriteLine("Your number is one");
            }

            if (numberOne == 2)
            {
                Console.WriteLine("Your number is two");
            }

            if (numberOne == 3)
            {
                Console.WriteLine("Your number is three");
            }

        }
    }
}
