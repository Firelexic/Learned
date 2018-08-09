using System;

namespace CharType
{
    public class StartUp
    {
        public static void Main()
        {
            //Declare a variable
            char symbol = 'a';
            //Print the result on the console
            Console.WriteLine("The code of " + symbol + " is " + (int)symbol);
            symbol = 'b';
            Console.WriteLine("The code of " + symbol + " is " + (int)symbol);
            symbol = 'A';
            Console.WriteLine("The code of " + symbol + " is " + (int)symbol);
        }
    }
}
