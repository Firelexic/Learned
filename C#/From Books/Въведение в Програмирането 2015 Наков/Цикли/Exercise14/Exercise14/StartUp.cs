﻿using System;

namespace Exercise14
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter decimal number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 10), 16);
            Console.WriteLine("Result is {0}", toDecimal)
        }
    }
}
