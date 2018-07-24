using System;

namespace MethodsOutParamExam
{
    public class StartUp
    {
        static void Getrect(int l,int b,out int a)
        {
            a = l * b;
        }

        public static void Main()
        {
            int u = 50;
            int v = 8;
            int z;
            Getrect(u, v, out z);
            Console.WriteLine("Area of rectangle is {0} ",z);
        }
    }
}
