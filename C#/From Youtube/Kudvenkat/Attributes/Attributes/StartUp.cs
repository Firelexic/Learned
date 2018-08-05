using System;
using System.Collections.Generic;

namespace Attributes
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(Calculator.Add(new List<int>() { 10, 20, 40, 50 }));
            int n = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                intList.Add(num);
            }

            Console.WriteLine(Calculator.Add(intList));
        }
    }
}
