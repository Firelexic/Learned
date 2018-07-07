using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxForNumericTypes
{
    class MaxForNumericTypes
    {
        static void Main()
        {
            var numbers = new List<int> { 1, 8, 3, 2 };
            int maxNumber = numbers.Max();
            Console.WriteLine(maxNumber);

            var num = new List<decimal> { 1.0m, 8.1m, 3.3m, 2.0m };
            decimal maxNum = num.Max();
            Console.WriteLine(maxNum);

            var number = new List<int>();
            int maxnumb = number.Max();
            Console.WriteLine(maxnumb);

        }
    }
}
