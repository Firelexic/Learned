using System;

namespace Input
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Please Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name} !");
        }
    }
}
