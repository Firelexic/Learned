using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQsumWithQuerySyntax
{
    class LINQsumWithQuerySyntax
    {
        static void Main()
        {
            var list = new List<int> { 8, 2, 6, 3 };
            int sum = (from x in list select x).Sum();
            Console.WriteLine(sum);

            var query = new List<int> { 8, 2, 6, 3 };
            int summ = (from x in list where x > 4 select x).Sum();
            Console.WriteLine(summ);

            var listquery = new List<string> { "88888888","22",
            "666666","333"};
            int lengthSum = (from x in listquery select x.Length).Sum();
            Console.WriteLine(lengthSum);
        }
    }
}
