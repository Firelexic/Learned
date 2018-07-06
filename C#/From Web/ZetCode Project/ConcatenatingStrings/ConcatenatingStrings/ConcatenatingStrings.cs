using System;
using System.Text;

namespace ConcatenatingStrings
{
    class ConcatenatingStrings
    {
        static void Main()
        {
            Console.WriteLine("Return" + " of " + "the king.");
            Console.WriteLine(string.Concat(string.Concat
                ("Return"," of "),"The king."));

            StringBuilder sb = new StringBuilder();
            sb.Append("Return");
            sb.Append(" of ");
            sb.Append("the king.");

            Console.WriteLine(sb);
        }
    }
}
