using System;
using System.Collections.Generic;
using System.Linq;

namespace ForeachWithContinue
{
    class ForeachWithContinue
    {
        static void Main()
        {
            var list = new List<string>() { "John", "Tom", "Peter" };
            foreach (string name in list)
            {
                if (name == "Tom")
                {
                    continue;
                }
                Console.WriteLine(name);
            }
        }
    }
}
