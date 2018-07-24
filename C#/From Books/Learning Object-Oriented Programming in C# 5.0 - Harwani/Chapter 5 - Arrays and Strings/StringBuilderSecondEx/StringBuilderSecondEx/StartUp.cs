using System;
using System.Text;

namespace StringBuilderSecondEx
{
    public class StartUp
    {
        public static void Main()
        {
            string str;
            StringBuilder sb = new StringBuilder("It is hot today");
            Console.WriteLine("Original string builder is : {0} ",sb);
            sb.Replace("is", "was");
            Console.WriteLine("Modified string builder is : {0}",sb);
            sb[0] = 'A';
            Console.WriteLine("The string builder after replacing first character is : {0}",sb);
            sb.Remove(7, 3);
            Console.WriteLine("The string builder after removing word is : {0} ",sb);
            str = sb.ToString();
            Console.WriteLine("The string builder converted into string : {0}",str);
        }
    }
}
