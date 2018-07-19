using System;

namespace IfElseCharFunc
{
    public class StartUp
    {
        public static void Main()
        {
            char n;
            Console.WriteLine("Enter a character : ");
            n = Char.Parse(Console.ReadLine());
            if (char.IsDigit(n))
            {
                Console.WriteLine("You have entered a digit");
            }
            else
            {
                if (char.IsLetter(n))
                {
                    if (char.IsLower(n))
                    {
                        Console.WriteLine("You have entered a letter in lowercase");
                    }
                    else
                    {
                        Console.WriteLine("You have entered a letter in uppercase");
                    }
                }
                else
                {
                    if (char.IsPunctuation(n))
                    {
                        Console.WriteLine("You have entered punctuation");
                    }
                    else
                    {
                        if (char.IsWhiteSpace(n))
                        {
                            Console.WriteLine("You have entered whitespace");
                        }
                        else
                        {
                            Console.WriteLine("You have entered something else");
                        }
                    }
                }
            }
        }
    }
}
