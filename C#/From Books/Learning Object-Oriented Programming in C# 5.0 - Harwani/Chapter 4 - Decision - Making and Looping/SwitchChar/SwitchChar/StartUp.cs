using System;

namespace SwitchChar
{
    public class StartUp
    {
        public static void Main()
        {
            char n;
            Console.WriteLine("Enter a character between a and d :");
            n = Convert.ToChar(Console.ReadLine().ToLower());

            switch (n)
            {
                case 'a':
                    Console.WriteLine("Apple");
                    break;
                case 'b':
                    Console.WriteLine("Bat");
                    break;
                case 'c':
                    Console.WriteLine("Cat");
                    break;
                case 'd':
                    Console.WriteLine("Dog");
                    break;
                default:
                    Console.WriteLine("The character entered is out of range");
                    break;
            }
        }
    }
}
