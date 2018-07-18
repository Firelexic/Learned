using System;

namespace StringJoined
{
    public class StartUp
    {
        public static void Main()
        {
            string[] a = new string[3] { "Alpha", "Bravo", "Charlie" };
            string s = String.Concat(a[0], a[1]);
            Console.WriteLine($"Concatenated : {s}");

            s = String.Join(" ", a[0], a[1]);
            Console.WriteLine($"Joined: {s}");

            s = String.Join("<b>", a);
            Console.WriteLine("HTML : " + s );

            int num = String.Compare(a[0], a[1]);
            Console.WriteLine(a[0] + " v " + a[1] + " " + num);
        }
    }
}
