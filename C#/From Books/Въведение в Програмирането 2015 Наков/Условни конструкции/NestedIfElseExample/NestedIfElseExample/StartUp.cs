using System;

namespace NestedIfElseExample
{
    public class StartUp
    {
        public static void Main()
        {
            char ch = 'X';
            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("Vowel [ei]");
            }
            else if (ch == 'E' || ch == 'e')
            {
                Console.WriteLine("Vowel [i:]");
            }
            else if (ch == 'I' || ch == 'i')
            {
                Console.WriteLine("Vowel [ai]");
            }
            else if (ch == 'O' || ch == 'o')
            {
                Console.WriteLine("Vowel [ou]");
            }
            else if (ch == 'U' || ch == 'u')
            {
                Console.WriteLine("Vowel [ju:]");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
