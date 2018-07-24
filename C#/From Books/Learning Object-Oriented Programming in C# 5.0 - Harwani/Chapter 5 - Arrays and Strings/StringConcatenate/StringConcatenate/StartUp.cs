using System;

namespace StringConcatenate
{
    public class StartUp
    {
        public static void Main()
        {
            string strOne = "Hello";
            string strTwo = "World!";
            Console.WriteLine("The string two strings are {0}" +
                " and {1}",strOne,strTwo);
            strOne += " ";
            strOne += strTwo;
            Console.WriteLine("The string after concatenation is {0}",strOne);
        }
    }
}
