using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxWithSelector
{
    class MaxWithSelector
    {
        static void Main()
        {
            var stringList = new List<string> { "1", "88888888", "333", "22" };

            //these two lines do the same
            int maxLength = stringList.Select(x => x.Length).Max();
            Console.WriteLine(maxLength);
            int maxLengths = stringList.Max(x => x.Length);
            Console.WriteLine(maxLengths);
        }
    }
}
