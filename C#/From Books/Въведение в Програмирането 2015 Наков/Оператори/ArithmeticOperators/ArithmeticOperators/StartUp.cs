﻿using System;

namespace ArithmeticOperators
{
    public class StartUp
    {
        public static void Main()
        {
            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide);
            Console.WriteLine(squareArea);

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine(a + b++);
            Console.WriteLine(b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + (++b));
            Console.WriteLine(14 / a);
            Console.WriteLine(14 % a);


            int one = 1;
            int zero = 0;
            //Console.WriteLine(one / zero); - DivideBy zero exception

            double dMinusOne = -1.0;
            double dZero = 0.0;

            Console.WriteLine(dMinusOne / dZero);
            Console.WriteLine(one / dZero);
        }
    }
}
