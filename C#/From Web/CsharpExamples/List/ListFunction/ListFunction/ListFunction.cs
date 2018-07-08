using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFunction
{
    class ListFunction
    {
        static void Main()
        {
            var list = new List<int>() { 8, 3, 2 };
            var listB = new List<int>();

            //List.Equals
            listB = list;
            bool result = list.Equals(listB);
            Console.WriteLine(result);
            foreach (var ele in listB)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("----------------");
            //List.Find
            int item = list.Find(x => x > 2);
            Console.WriteLine(item);
            //List.FindAll
            var listC = list.FindAll(x => x > 2);
            foreach (var ele in listC)
            {
                Console.WriteLine(ele);
            }



        }
    }
}
