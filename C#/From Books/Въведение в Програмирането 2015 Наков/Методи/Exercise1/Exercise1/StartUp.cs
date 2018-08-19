using System;

namespace Exercise1
{
    public class StartUp
    {
        public static void Name(string name)
        {
            Console.WriteLine("Hello, {0} !",name);
        }

        public static void Main()
        {
            string name = Console.ReadLine();
            Name(name);
        }
    }
}
