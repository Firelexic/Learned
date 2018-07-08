using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicForeachLoop
{
    class BasicForeachLoop
    {
        static void Main()
        {
            var list = new List<string>() { "John", "Tom", "Peter" };
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }
            Console.WriteLine("-----------------");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
