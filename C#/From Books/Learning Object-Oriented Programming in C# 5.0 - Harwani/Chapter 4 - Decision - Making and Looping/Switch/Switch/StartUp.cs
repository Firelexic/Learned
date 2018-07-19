using System;

namespace Switch
{
    public class StartUp
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter a number between 1 and 4 : ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                default:
                    Console.WriteLine("The number is out of range");
                    break;
            }
        }
    }
}
