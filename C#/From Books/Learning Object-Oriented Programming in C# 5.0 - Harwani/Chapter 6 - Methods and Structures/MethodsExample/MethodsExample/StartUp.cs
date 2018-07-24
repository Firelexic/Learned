using System;

namespace MethodsExample
{
    public class StartUp
    {
        static void MathOp(int a,int b,out int c,out int d,out float e)
        {
            c = a + b;
            d = a * b;
            e = (float)a / b;
        }

        public static void Main()
        {
            int u = 10;
            int v = 20;
            int add, mult;
            float div;
            MathOp(u, v, out add, out mult, out div);
            Console.WriteLine("Value of u = {0} and v = {1} . Their addition is {2}" +
                " multiplication is {3}, and division is {4}",u,v,add,mult,div);
        }
    }
}
