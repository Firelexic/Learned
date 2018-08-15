using System;

namespace UsingReadLine
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please,enter your first name : ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please, enter your last name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}",firstName,lastName);
        }
    }
}
