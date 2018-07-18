using System;

namespace Variables
{
    public class StartUp

    {
        public static void Main()
        {
            char letter;
            letter = 'A';
            int number;
            number = 100;
            float body = 98.6f;
            double pi = 3.14159;
            decimal sum = 1000.00m;
            bool flag = false;
            string text = "C# is Fun";

            Console.WriteLine("char letter : " + letter);
            Console.WriteLine("int number : " + number);
            Console.WriteLine("floatt body : " + body);
            Console.WriteLine("double pi :" + pi);
            Console.WriteLine("decimal sum : " + sum);
            Console.WriteLine("bool flag : " + flag);
            Console.WriteLine("string text : " + text);
        }
    }
}
