using System;
using System.Collections.Generic;

namespace TheListConvert
{
    public class StartUp
    {
        public static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
        public static void Main()
        {
            List<int> integers = new List<int>();
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);
            Converter<int, double> converter = TakeSquareRoot;
            List<double> doubles;
            doubles = integers.ConvertAll<double>(converter);
            foreach (double d in doubles)
            {
                Console.WriteLine(d);
            }

        }
    }
}
