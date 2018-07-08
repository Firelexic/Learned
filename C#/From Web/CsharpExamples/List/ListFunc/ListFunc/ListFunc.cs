using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFunc
{
    class ListFunc
    {
        static void Main()
        {
            //Declare
            var list = new List<int>() { 8, 3, 2 };
            var listSecond = new List<int>() { 5, 7 };

            //List[index]
            int itemZero = list[0];
            int itemFirst = list[1];
            int itemSecond = list[2];
            Console.WriteLine(itemZero);
            Console.WriteLine(itemFirst);
            Console.WriteLine(itemSecond);

            //List.Add
            list.Add(5);
            Console.WriteLine(list[3]);

            Console.WriteLine("--------------------------");
            //List.AddRange
            list.AddRange(listSecond);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            //List.Clear
            list.Clear();
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
