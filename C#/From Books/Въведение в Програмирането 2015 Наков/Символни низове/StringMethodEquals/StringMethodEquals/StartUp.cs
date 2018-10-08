using System;

namespace StringMethodEquals
{
    public class StartUp
    {
        public static void Main()
        {
            string word1 = "C#";
            string word2 = "c#";
            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word1.Equals(word2));
            Console.WriteLine(word1 == "C#");
            Console.WriteLine(word1 == word2);

            Console.WriteLine(word1.Equals(word2,StringComparison.CurrentCultureIgnoreCase));

        }
    }
}
