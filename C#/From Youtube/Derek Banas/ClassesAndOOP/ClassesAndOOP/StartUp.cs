using System;

namespace ClassesAndOOP
{
    public class StartUp
    {
        public static void Main()
        {
            Rectangle rectOne;
            rectOne.length = 200;
            rectOne.width = 50;
            Console.WriteLine("Area of rectOne : {0}",rectOne.Area());

            Rectangle rectTwo = new Rectangle(100, 40);
            rectTwo = rectOne;

            rectOne.length = 33;
            Console.WriteLine("rectTwo.Length = {0}",rectTwo.length);
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
