using System;

namespace ClassDemoThree
{
    public class StartUp
    {
        public static void Main()
        {
            RectArea rect = new RectArea();
            TriangleArea trg = new TriangleArea();
            rect.SetData(5, 8);
            trg.SetValue(9, 7);
            Console.WriteLine("Area of rectangle is {0}",rect.GetRect());
            Console.WriteLine("Area of triangle is {0}",trg.GetTriangle());
        }
    }
}
