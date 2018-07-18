using System;

namespace Conversion
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter A Number: ");
            double num = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter Another Number: ");
            double sum = num + int.Parse(Console.ReadLine());
            Console.WriteLine($"Total = {sum}");
        }
    }
}
