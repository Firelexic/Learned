using System;
using System.Collections.Generic;
using System.Linq;

namespace MinForNullableNumericTypes
{
    class MinForNullableNumericTypes
    {
        static void Main()
        {
            var num = new List<int?> { 8, 2, null, 3 };
            int? minNum = num.Min();
            Console.WriteLine(minNum);

            var numb = new List<int?> { null };
            int? minNumb = numb.Min();
            Console.WriteLine(minNumb);

            var numbers = new List<int?>();
            int? minNumber = numbers.Min();
            Console.WriteLine(minNumber);
        }
    }
}
