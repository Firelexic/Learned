using System;
using System.Collections.Generic;
using System.Linq;


namespace AverageWithSelector
{
    class AverageWithSelector
    {
        static void Main()
        {
            var stringList = new List<string> { "1", "88888888", "333", "22" };

            double result = stringList.Select(x => x.Length).Average();
            Console.WriteLine(result);
            double resultNum = stringList.Average(x => x.Length);
            Console.WriteLine(resultNum);
        }
    }
}
