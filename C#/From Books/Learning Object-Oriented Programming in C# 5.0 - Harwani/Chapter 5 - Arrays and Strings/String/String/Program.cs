using System;

namespace String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s;
            Console.Write("Enter a string ");
            s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
                Console.WriteLine("The string is empty");
            else
            {
                string substr = s.Substring(0, 3);
                Console.WriteLine("Original string is {0}," +
                    "its length is {1} and its first three " +
                    "characters are {2}",s,s.Length,substr);
            }
        }
    }
}
