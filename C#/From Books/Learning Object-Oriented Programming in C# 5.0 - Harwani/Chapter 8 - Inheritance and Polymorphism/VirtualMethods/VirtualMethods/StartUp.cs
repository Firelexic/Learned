using System;

namespace VirtualMethods
{
    public class StartUp
    {
        public static void Main()
        {
            Rect r = new Rect();
            r.SetValue(5, 8);
            Console.WriteLine("Area of rectangle is : {0}",r.Area());
            Triangle t = new Triangle();
            t.GetValue();
            Console.WriteLine("Area of triangle is : {0}",t.Area());
        }
    }
}
