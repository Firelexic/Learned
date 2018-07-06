using System;

namespace StringElements
{
    class StringElements
    {
        static void Main()
        {
            char[] crs = { 'Z', 'e', 't', 'C', 'o', 'd', 'e' };
            String s = new String(crs);

            char c1 = s[0];
            char c2 = s[(s.Length - 1)];

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            int iOne = s.IndexOf('e');
            int iTwo = s.LastIndexOf('e');

            Console.WriteLine("The first index of character e is " + iOne);
            Console.WriteLine("The last index of character e is " + iTwo);

            Console.WriteLine(s.Contains("t"));
            Console.WriteLine(s.Contains("f"));

            char[] elements = s.ToCharArray();

            foreach (char element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
