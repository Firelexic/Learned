using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxWithQuerySyntax
{
    class MaxWithQuerySyntax
    {
        static void Main()
        {
            var list = new List<int> { 1, 8, 3, 2 };
            int maxNumber = (from x in list select x).Max();
            Console.WriteLine(maxNumber);

            var listNumber = new List<int> { 1, 8, 3, 2 };
            int maxListNumber = (from x in listNumber where x < 5 select x).Max();
            Console.WriteLine(maxListNumber);
        }
    }
}
