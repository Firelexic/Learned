﻿using System;

namespace FourthExercise
{
    public class Program
    {
        public static void Main()
        {
            int number = 452;
            Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);
        }
    }
}
