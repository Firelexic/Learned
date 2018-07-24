using System;

namespace MethodsPassByRef
{
    public class StartUp
    {
        static int GetRect(ref int l,ref int b)
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
            Console.WriteLine("Before calling method. Value of u = {0} and v = {0} ",u,v);
            int z = GetRect(ref u, ref v);
            Console.WriteLine("Area of rectangle is {0}",z);
            Console.WriteLine("After calling method . Value of u = {0} and v = {1} ",u,v);
        }
    }
}
