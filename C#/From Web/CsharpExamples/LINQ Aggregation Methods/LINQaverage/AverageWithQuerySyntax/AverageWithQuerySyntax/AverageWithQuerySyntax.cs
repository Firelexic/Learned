using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageWithQuerySyntax
{
    class AverageWithQuerySyntax
    {
        static void Main()
        {
            var list = new List<int> { 1, 8, 3, 2 };
            double result = (from x in list select x).Average();
            Console.WriteLine(result);

            var listOfNum = new List<int> { 8, 1, 3, 2 };
            double resultOfNum = (from x in listOfNum where x < 5 select x).Average();
            Console.WriteLine(resultOfNum);
        }
    }
}
