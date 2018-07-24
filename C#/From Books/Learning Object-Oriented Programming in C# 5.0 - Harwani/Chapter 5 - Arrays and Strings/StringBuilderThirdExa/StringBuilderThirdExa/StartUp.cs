using System;
using System.Text;

namespace StringBuilderThirdExa
{
    public class StartUp
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Value1 : {0}, value 2 : {1} , Addition is {2} ", 10, 20, 30);
            Console.WriteLine("Original stringbuilder is : {0}",sb);
            sb.Insert(24, "and");
            Console.WriteLine("The string builder after inserting a word is : {0}",sb);
            sb.Append(" inits");
            Console.WriteLine("The stringbuilder after appending a word is : {0}",sb);
        }
    }
}
