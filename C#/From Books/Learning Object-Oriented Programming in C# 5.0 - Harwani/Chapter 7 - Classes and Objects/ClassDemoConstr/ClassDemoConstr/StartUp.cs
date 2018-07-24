using System;

namespace ClassDemoConstr
{
    public class StartUp
    {
        public static void Main()
        {
            RectArea rect = new RectArea();
            Console.WriteLine("Area of rectangle is {0}",rect.GetRect());
        }
    }
}
