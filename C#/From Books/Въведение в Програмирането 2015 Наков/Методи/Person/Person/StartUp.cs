using System;

namespace Person
{
    public class StartUp
    {
        public static void PrintNameAndAge(string name,int age)
        {
            Console.WriteLine("I am {0}, {1} year(s) old.",name,age);
        }

        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            PrintNameAndAge(name,age);
        }
    }
}
