using System;
using System.Text;

namespace MutableImmutableString
{
    class MutableImmutableString
    {
        static void Main()
        {
            string name = "Jane";
            string nameTwo = name.Replace('J', 'K');
            string nameThree = nameTwo.Replace('n', 't');

            Console.WriteLine(name);
            Console.WriteLine(nameThree);

            StringBuilder sb = new StringBuilder("Jane");
            Console.WriteLine(sb);

            sb.Replace('J', 'K', 0, 1);
            sb.Replace('n', 't', 2, 1);
            
            Console.WriteLine(sb);
        }
    }
}
