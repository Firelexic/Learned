using System;

namespace StringFeatures
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter Text : ");
            string text = Console.ReadLine();


            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("Error : No Text Found!");
            }
            else
            {
                Console.WriteLine($"Thanks, your Entered : {text} ");
                Console.WriteLine($"Text length : {text.Length}");
            }

            string query = text.StartsWith("C#") ? "Does" : "Does Not";
            Console.WriteLine("Text " + query + " Start with C#");


            query = text.EndsWith("steps") ? "Does" : "Doest Not";
            Console.WriteLine($"Test {query} end With steps");

            query = text.Contains("easy") ? "Does" : "Doest Not";
            Console.WriteLine($"Text {query} Contain easy");
        }
    }
}
