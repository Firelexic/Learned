using System;

namespace AbstractExample
{
    public class StartUp
    {
        public static void Main()
        {
            Rect r = new Rect();
            Triangle t = new Triangle();
            r.GetRect(5, 8);
            t.GetTrig();
            Console.WriteLine("Area of rectangle is : {0}",r.Area());
            Console.WriteLine("Area of triangle is : {0}",t.Area());
        }
    }
}
