using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAverage
{
    class LinqAverage
    {
        static void Main()
        {
            var list = new List<int> { 8, 1, 3, 2 };
            double result = list.Average();
            Console.WriteLine(result);

            var listOfNum = new List<decimal> { 1.0m, 8.1m, 3.3m, 2.0m };
            decimal resultNum = listOfNum.Average();
            Console.WriteLine(resultNum);

            var listOfNumbers = new List<int?> { 1, 8, null, 3 };
            double? resultNumber = list.Average();
            Console.WriteLine(resultNumber);
        }
    }
}
