using System;
using System.Text;

namespace ElementsOfAString
{
    class ProgramElementsOfAString
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Misty mountains");
            Console.WriteLine(sb);

            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);

            sb.Append('s');
            Console.WriteLine(sb);

            sb.Insert(0, 'T');
            sb.Insert(1, 'h');
            sb.Insert(2, 'e');
            sb.Insert(3, ' ');
            Console.WriteLine(sb);

            sb.Replace('M', 'm', 4, 1);
            Console.WriteLine(sb);
        }
    }
}
