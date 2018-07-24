using System;

namespace ClassDemoConst
{
    public class StartUp
    {
        public static void Main()
        {
            RectArea rectOne = new RectArea(5,8);
            RectArea rectTwo = new RectArea(10,20);
            Console.WriteLine("Area of first rectangle is {0}",rectOne.GetRect());
            Console.WriteLine("Area of second  rectangle is {0} ",rectTwo.GetRect());
        }
    }
}
