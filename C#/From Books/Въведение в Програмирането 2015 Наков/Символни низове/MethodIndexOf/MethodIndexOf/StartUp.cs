using System;

namespace MethodIndexOf
{
    public class StartUp
    {
        public static void Main()
        {
            string book = "Introduction to C# book";
            int index = book.IndexOf("C#");
            Console.WriteLine(index);
        }
    }
}
