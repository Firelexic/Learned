using System;
using System.Collections.Generic;
using System.Linq;

namespace MinForNumericalTypes
{
    class MinForNumericalTypes
    {
        static void Main()
        {
            var num = new List<int> { 8, 2, 6, 3 };
            int minNum = num.Min();
            Console.WriteLine(minNum);

            var numb = new List<decimal> { 8.1m, 2.2m, 6.1m, 3.3m };
            decimal minNumb = numb.Min();
            Console.WriteLine(minNumb);

            var number = new List<int>();
            int minNumber = number.Min();
            Console.WriteLine(minNumber);
        }
    }
}
