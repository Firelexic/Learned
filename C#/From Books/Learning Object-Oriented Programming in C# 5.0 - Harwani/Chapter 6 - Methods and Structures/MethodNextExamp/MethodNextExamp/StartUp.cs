using System;

namespace MethodNextExamp
{
    public class StartUp
    {
        static int GetRect(int l,int b)
        {
            int a = l * b;
            l = 10;
            b = 20;
            return a;
        }

        public static void Main()
        {
            int u = 50;
            int v = 8;
            Console.WriteLine("Before calling method. Value of u = {0} and v {1}",u,v);
            int z = GetRect(u, v);
            Console.WriteLine("Area of rectangle is {0}",z);
            Console.WriteLine("After calling method. Value of u = {0} and v = {1}",u,v);
        }
    }
}
