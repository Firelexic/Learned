using System;

namespace RectangleArea
{
    public class StartUp
    {
        public static double GetRectangleArea(double width,double height)
        {
            double area = width * height;
            return area;
        }
        public static void Main()
        {
            Console.WriteLine(GetRectangleArea(5,7));
        }
    }
}
