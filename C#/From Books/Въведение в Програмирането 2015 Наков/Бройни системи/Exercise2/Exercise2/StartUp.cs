﻿using System;

namespace Exercise2
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("1111010110011110 to decimal is {0}",Convert.ToInt32("1111010110011110",2));

            Console.WriteLine("1111010110011110 to hexadecimal is {0}",Convert.ToInt64("1111010110011110",2).ToString("X"));
        }
    }
}
