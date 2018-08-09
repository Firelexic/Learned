using System;

namespace PrintArrayWithForeach
{
    public class StartUp
    {
        public static void Main()
        {
            string[] capitals =
            {
                "Sofia",
                "Washington",
                "London",
                "Paris"
            };

            foreach (string capital in capitals)
            {
                Console.WriteLine(capital);
            }
        }
    }
}
