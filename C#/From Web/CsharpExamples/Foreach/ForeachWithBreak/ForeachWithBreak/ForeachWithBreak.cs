using System;
using System.Collections.Generic;
using System.Linq;

namespace ForeachWithBreak
{
    class ForeachWithBreak
    {
        static void Main()
        {
            var names = new List<string>() { "John", "Tom", "Peter" };
            foreach (string name in names)
            {
                if (name == "Tom")
                {
                    break;
                }
                Console.WriteLine(name);
            }
        }
    }
}
