using System;
using System.Collections.Generic;
using System.Linq;

namespace CountWithPredicate
{
    class CountWithPredicate
    {
        static void Main()
        {
            IEnumerable<int> items = new List<int> { 8, 3, 2 };

            int count = items.Where(x => x < 5).Count();
            Console.WriteLine(count);
            int counts = items.Count(x => x < 5);
            Console.WriteLine(counts);
        }
    }
}
