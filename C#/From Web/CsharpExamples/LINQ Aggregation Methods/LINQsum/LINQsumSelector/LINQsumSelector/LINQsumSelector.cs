using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQsumSelector
{
    class LINQsumSelector
    {
        static void Main()
        {
            var stringList = new List<string> { "88888888","22","666666",
            "333"};

            //these two lines do the same
            int lenghtSum = stringList.Select(x => x.Length).Sum();
            Console.WriteLine(lenghtSum);
            int lenghtSumm = stringList.Sum(x => x.Length);
            Console.WriteLine(lenghtSumm);
        }
    }
}
