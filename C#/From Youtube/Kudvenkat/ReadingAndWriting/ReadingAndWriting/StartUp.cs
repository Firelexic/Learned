using System;

namespace ReadingAndWriting
{
    public class StartUp
    {
        public static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int sumNumbers = numOne + numTwo;
            Console.WriteLine(sumNumbers);
        }
    }
}
