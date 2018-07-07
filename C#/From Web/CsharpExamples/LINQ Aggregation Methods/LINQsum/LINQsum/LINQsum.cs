using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQsum
{
    class LINQsum
    {
        static void Main()
        {
            //Sum for Numeric Types
        
            var numbers = new List<int> { 8, 2, 6, 3 };
            int sum = numbers.Sum();
            Console.WriteLine(sum);

            var numberss = new List<decimal> { 8.1m, 2.2m, 6.1m, 3.3m };
            decimal summ = numberss.Sum();
            Console.WriteLine(summ);

            var nums = new List<int>();
            int sums = nums.Sum();
            Console.WriteLine(sums);

            //Sum for Nullable Numeric Types
            var num = new List<int?> { 8, 2, null, 3 };
            int? ssum = num.Sum();
            Console.WriteLine(ssum);
        }
    }
}
