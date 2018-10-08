using System;

namespace StringMethodCompareTo
{
    public class StartUp
    {
        public static void Main()
        {
            string score = "sCore";
            string scary = "scary";

            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));
        }
    }
}
