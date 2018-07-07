using System;
using System.Collections.Generic;
using System.Linq;

namespace MinWithQuerySyntax
{
    class Program
    {
        static void Main()
        {
            var list = new List<int> { 8, 2, 6, 3 };
            int minNumb = (from x in list select x).Min();
            Console.WriteLine(minNumb);

            var query = new List<int> { 8, 2, 6, 3 };
            int minNumber = (from x in query where x > 4 select x).Min();
            Console.WriteLine(minNumber);
        }
    }
}
