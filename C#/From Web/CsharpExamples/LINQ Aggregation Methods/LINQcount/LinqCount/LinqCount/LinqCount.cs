using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCount
{
    class LinqCount
    {
        static void Main()
        {
            IEnumerable<string> items = new List<string> { "A", "B", "C" };
            int count = items.Count();
            Console.WriteLine(count);

            IEnumerable<string> item = new List<string> { };
            int counts = item.Count();
            Console.WriteLine(counts);
        }
    }
}
