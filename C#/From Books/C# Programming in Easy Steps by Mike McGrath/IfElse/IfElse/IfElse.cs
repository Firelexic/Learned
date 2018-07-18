using System;

namespace IfElse
{
    public  class IfElse
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter A Number : ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("Thanks, Now Enter A Letter: ");
            char letter = char.Parse(Console.ReadLine());
            if (num >= 6)
            {
                Console.WriteLine("Number Exceeds 5");
            }
            else
            {
                Console.WriteLine("Number Is 5 Or Less");
            }

            if (letter == 'C')
            {
                Console.WriteLine("Letter is C");
            }
        }
    }
}
