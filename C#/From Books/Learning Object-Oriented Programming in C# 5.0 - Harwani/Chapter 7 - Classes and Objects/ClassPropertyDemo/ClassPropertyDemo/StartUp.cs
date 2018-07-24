using System;

namespace ClassPropertyDemo
{
    public class StartUp
    {
        public static void Main()
        {
            Rect r = new Rect();
            Console.WriteLine("Initial values of length and breadth are {0} and {1}",
                r.Length,r.Breadth);
            r.Length = 5;
            r.Breadth = 8;
            Console.WriteLine("Length = {0},Breadth = {1} and area of rectangle is {2}",
                r.Length,r.Breadth,r.Length * r.Breadth);
            r.Length = -10;
            r.Breadth = 20;
            Console.WriteLine("Length = {0}, Breadth = {1} and Area of rectangle is {2}",
                r.Length,r.Breadth,r.Length*r.Breadth);
        }
    }
}
