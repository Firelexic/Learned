using System;
using System.Collections.Generic;
using System.Linq;

namespace MinWithSelector
{
    class MinWithSelector
    {
        static void Main()
        {
            var stringList = new List<string> { "88888888", "22", "666666", "333" };

            int minLength = stringList.Select(x => x.Length).Min();
            Console.WriteLine(minLength);
            int minLeng = stringList.Min(x => x.Length);
            Console.WriteLine(minLeng);
        }
    }
}
