using System;

namespace ClassDemo
{
    public class StartUp
    {
        public static void Main()
        {
            RectArea rect = new RectArea();
            rect.l = 5;
            rect.b = 8;
            rect.a = rect.l * rect.b;
            Console.WriteLine("Area of rectangle is {0}",rect.a);
        }
    }
}
