using System;

namespace MethodOverloading
{
    public class StartUp
    {
        static int GetRect()
        {
            int l, b, a;
            l = 50;
            b = 8;
            a = l * b;
            return a;
        }

        static int GetRect(int l)
        {
            int b, a;
            b = 10;
            a = l * b;
            return a;
        }

        static int GetRect(int l,int b)
        {
            int a = l * b;
            return a;
        }

        public static void Main()
        {
            int x, y, z;
            x = GetRect();

            y = GetRect(20);
            z = GetRect(30, 5);
            Console.WriteLine("Area of first rectangle is {0}",x);
            Console.WriteLine("Area of second rectangle is {0}",y);
            Console.WriteLine("Area of third rectangle is {0}",z);
        }
    }
}
