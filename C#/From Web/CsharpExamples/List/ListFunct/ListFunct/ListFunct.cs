using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFunct
{
    class ListFunct
    {
        static void Main()
        {
            var list = new List<int>() { 8, 3, 2 };

            //List.Contains
            bool result = list.Contains(3);
            Console.WriteLine(result);
            bool contain = list.Contains(7);
            Console.WriteLine(contain);

            //List.ConvertAll
            var conv = new Converter<int, decimal>(x => (decimal)(x + 1));
            var listB = list.ConvertAll<decimal>(conv);
            foreach (var element in listB)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------");
            //List.CopyTo
            decimal[] array = new decimal[10];
            listB.CopyTo(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //List.Exists 
            bool resultN = list.Exists(x => x == 3);
            Console.WriteLine(resultN);
        }
    }
}
