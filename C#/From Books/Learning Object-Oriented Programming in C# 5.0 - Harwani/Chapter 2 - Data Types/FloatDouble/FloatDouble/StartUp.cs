﻿using System;

namespace FloatDouble
{
    public class StartUp
    {
        public static void Main()
        {
            float a;
            double b;
            a = 3.0F / 7.0f;
            b = 3.0 / 7.0;

            Console.WriteLine("Float value of 3.0 / 7.0 expression is {0} and " +
                "double value is {1}", a, b);
        }
    }
}
