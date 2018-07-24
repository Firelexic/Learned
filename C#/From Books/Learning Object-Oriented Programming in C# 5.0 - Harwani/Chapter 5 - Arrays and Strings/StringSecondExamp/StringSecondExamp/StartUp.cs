using System;

namespace StringSecondExamp
{
    public class StartUp
    {
        public static void Main()
        {
            string s;
            Console.WriteLine("Enter a string ");
            s = Console.ReadLine();
            Console.WriteLine("The character wise display of the string {0} is ",s);
            int n = s.Length;
            for (int i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("{0}",s.Substring(i,1));
            }
        }
    }
}
