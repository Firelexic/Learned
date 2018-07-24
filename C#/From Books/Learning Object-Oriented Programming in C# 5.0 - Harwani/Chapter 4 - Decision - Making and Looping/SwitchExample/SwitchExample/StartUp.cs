using System;

namespace SwitchExample
{
    public class StartUp
    {
        static Random random = new Random();
        public static char GetLetter()
        {
            // This method returns a random lowercase letter
            // ... Between 'a' and 'z' inclusize.
            int num = random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }

        public static void Main()
        {
            char n;
            n = GetLetter();
            Console.WriteLine(n);
            switch (n)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("The character entered is a vowel");
                    break;
                default:
                    Console.WriteLine("The character entered is a consonant");
                    break;
            }
        }
    }
}
