using System;

namespace StringManipulate
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter Text : ");
            string text = Console.ReadLine();

            Console.WriteLine("Thanks. You Entered: " + text + " ");
            Console.WriteLine("Text Length : " + text.Length);

            text = text.Trim();
            Console.WriteLine("Trimmed : " + text  + "");
            Console.WriteLine("Text Length : " + text.Length);

            string upper = text.ToUpper();
            Console.WriteLine("UpperCase : " + upper + " ");

            string lower = text.ToLower();
            Console.WriteLine("LowerCase : " + lower + " ");

            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40, '*');

            Console.WriteLine("Padded Left : " + upper + " ");
            Console.WriteLine("Padded Right : " + lower + " ");
            Console.WriteLine("Padded Both : " + text + " ");

            Console.WriteLine("Trimmed Start : " + upper.TrimStart() + " ");
            Console.WriteLine("Trimmed End : " + text.TrimEnd('*') + " ");

        }
    }
}
