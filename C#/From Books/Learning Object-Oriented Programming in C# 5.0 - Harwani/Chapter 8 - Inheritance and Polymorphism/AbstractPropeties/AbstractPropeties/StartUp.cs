using System;

namespace AbstractPropeties
{
    public class StartUp
    {
        public static void Main()
        {
            Rect r = new Rect();
            Triangle t = new Triangle();
            r.length = 5;
            r.breadth = 8;
            t.length = 5;
            t.breadth = 8;
            Console.WriteLine("Area of rectangle is : {0} ",r.Area());
            Console.WriteLine("Area of triangle is : {0} ",t.Area());
        }
    }
}
