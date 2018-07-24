using System;

namespace SingleInheritance
{
    public class StartUp
    {
        public static void Main()
        {
            TriangleArea triangle = new TriangleArea();
            triangle.SetRect(5, 8);
            triangle.SetTrg(19, 7);
            Console.WriteLine("Area of rectangle is {0}", triangle.GetRect());
            Console.WriteLine("Area of triangle is {0}",triangle.GetTrg());
        }
    }
}
