using System;

namespace DemoMethod
{
    public class StartUp
    {
        static int GetRect(int l,int b)
        {
            int a = l * b;
            return a;
        }

        public static void Main()
        {
            int u = 50, v = 8;
            int z = GetRect(u, v);
            Console.WriteLine("Area of rectangle is {0}",z);
        }
    }
}
