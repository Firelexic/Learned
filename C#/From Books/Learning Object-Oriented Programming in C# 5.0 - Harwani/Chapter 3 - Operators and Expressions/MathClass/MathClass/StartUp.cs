using System;

namespace MathClass
{
    public class StartUp
    {
        public static void Main()
        {
            double a = -10.15;
            double b = Math.Abs(a);
            double c = 90;
            double d = Math.Cos(c);
            double e = Math.Pow(2, 3);
            double f = 1.2;
            double g = Math.Exp(f);
            double h = 12.345678;
            double i = Math.Floor(h);
            double j = -12.345678;
            double k = Math.Floor(j);
            double l = Math.Ceiling(h);
            double m = Math.Ceiling(j);
            double n = Math.Truncate(h);
            double o = Math.Sqrt(2);
            Console.WriteLine("The absolute value of {0} is {1}",a,b);
            Console.WriteLine("The cosine of an angle of {0} rad is {1}",c,d);
            Console.WriteLine("2 to the power 3 is {0}",e);
            Console.WriteLine("e to the power {0} is {1}",f,g);
            Console.WriteLine("The largest integer less than or equal to {0} is {1}",h,i);
            Console.WriteLine("The largest integer less than or equal to {0} is {1}",j,k);
            Console.WriteLine("The smallest integer greater than or equal to {0} is {1}",h,l);
            Console.WriteLine("Value of Pi is {0}", Math.PI);
            Console.WriteLine("The truncated value of {0} is {1}", h, n);
            Console.WriteLine("The square root of 2 is {0}", o);
        }
    }
}
