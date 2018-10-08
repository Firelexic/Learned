using System;

namespace StringCompareMethod
{
    public class StartUp
    {
        public static void Main()
        {
            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";

            Console.WriteLine(string.Compare(alpha,score1,false));
            Console.WriteLine(string.Compare(score1,score2,false));
            Console.WriteLine(string.Compare(score1,score2,true));
            Console.WriteLine(string.Compare(score1,score1,StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
