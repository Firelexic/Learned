using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxForNullableNumericTypes
{
    class MaxForNullableNumericTypes
    {
        static void Main()
        {
            var number = new List<int?> { 1, 8, null, 3 };
            int? maxNumber = number.Max();
            Console.WriteLine(maxNumber);

            var numbers = new List<int?> { null };
            int? maxNumbers = numbers.Max();
            Console.WriteLine(maxNumbers);

            var num = new List<int?>();
            int? maxNum = num.Max();
            Console.WriteLine(maxNum);
        }
    }
}
