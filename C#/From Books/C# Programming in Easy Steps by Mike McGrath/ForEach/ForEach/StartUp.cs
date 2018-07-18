using System;

namespace ForEach
{
    public class StartUp
    {
        public static void Main()
        {
            string[] websites = new string[5]
            {
                "Google",
                "Youtube",
                "Facebook",
                "Baidu",
                "Yahoo!"
            };

            Console.WriteLine("Popular Websites...");

            int rank = 1;
            foreach (string site in websites)
            {
                Console.WriteLine($"Position: {rank} {site}");
                rank++;
            }
        }
    }
}
