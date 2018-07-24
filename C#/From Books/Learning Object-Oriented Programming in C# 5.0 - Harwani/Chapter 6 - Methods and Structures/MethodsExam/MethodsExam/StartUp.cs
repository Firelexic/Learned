using System;

namespace MethodsExam
{
    public class StartUp
    {
        static int GetRect(int l = 50, int b = 8)
        {
            int a = l * b;
            return a;
        }

        public static void Main()
        {
            int w, x, y, z;
            w = GetRect();
            x = GetRect(20);
            y = GetRect(b: 10);
            z = GetRect(30, 5);
            Console.WriteLine("Area of first rectangle is {0} ",w);
            Console.WriteLine("Area of second rectangle is {0} ",x);
            Console.WriteLine("Area of third rectangle is {0} ",y);
            Console.WriteLine("Area of fourth rectangle is {0}",z);

        }
    }
}
