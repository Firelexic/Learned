using System;
using System.Text;

namespace StringBuilderExmFirst
{
    public class StartUp
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("How many fruits are there ?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the names of {0} fruits",n);
            for (int i = 0; i <= n - 1; i++)
            {
                sb.AppendLine(Console.ReadLine());
            }
            Console.WriteLine("The fruit names entered are : ");
            Console.WriteLine(sb);
        }
    }
}
