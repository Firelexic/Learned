using System;

namespace CharType
{
    public class tartUp
    {
        public static void Main()
        {
            char a = 'A';
            char b = '1';
            char c = 'a';
            char d = '?';
            char e = ' ';

            Console.WriteLine("The caracter in variable a is {0}",a);
            Console.WriteLine("The variable b contains {0} and it is a digit value : {1}",b,char.IsDigit(b));
            Console.WriteLine("The variable c contains {0} and it is in lower case : {1}",c,char.IsLower(c));
            Console.WriteLine("The variable d contains {0} and it is a punctuation : {1}",d,char.IsPunctuation(d));
            Console.WriteLine("The variable e contains {0} and it is a white space : {1}",e,char.IsWhiteSpace(e));

        }
    }
}
