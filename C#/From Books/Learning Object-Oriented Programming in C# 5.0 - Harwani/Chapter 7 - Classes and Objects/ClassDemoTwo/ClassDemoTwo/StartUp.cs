using System;

namespace ClassDemoTwo
{
    public class StartUp
    {
        public static void Main()
        {
            RectArea rect = new RectArea();
            rect.SetData(5, 8);
            Console.WriteLine("Area of rectangle is {0}",rect.GetRect());
        }
    }
}
