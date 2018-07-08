using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class List
    {
        static void Main()
        {
            var listOne = new List<object>();
            var listTwo = new List<double>();
            var listThree = new List<int>();

            var listB = new List<int>() { 8, 3, 2 };
            var listA = new List<int>(listB);
            foreach (var element in listA)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i < listA.Count; i++)
            {
                Console.WriteLine(listA[i]);
            }

        }
    }
}
