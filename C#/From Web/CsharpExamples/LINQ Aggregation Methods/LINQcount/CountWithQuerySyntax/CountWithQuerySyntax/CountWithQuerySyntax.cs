using System;
using System.Collections.Generic;
using System.Linq;

namespace CountWithQuerySyntax
{
    class CountWithQuerySyntax
    {
        static void Main()
        {
            IEnumerable<int> items = new List<int> { 8, 3, 2 };
            int count = (from x in items select x).Count();
            Console.WriteLine(count);

            IEnumerable<int> item = new List<int> { 8, 3, 2 };
            int counts = (from x in item where x < 5 select x).Count();
            Console.WriteLine(counts);

        }
    }
}
