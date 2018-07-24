using System;

namespace ConstructorOverl
{
    public class StartUp
    {
        public static void Main()
        {
            RectArea rectOne = new RectArea();
            RectArea rectTwo = new RectArea(2);
            RectArea rectThree = new RectArea(5, 8);
            RectArea rectFour = new RectArea(3.75f, 6);
            RectArea rectFifth = new RectArea(4, 5.38f);
            RectArea rectSixth = new RectArea(2.25f, 5.30f);
            Console.WriteLine("Area of first rectangle is {0}",rectOne.GetRect());
            Console.WriteLine("Area of second rectangle is {0}",rectTwo.GetRect());
            Console.WriteLine("Area of third rectangle is {0}",rectThree.GetRect());
            Console.WriteLine("Area of fourth rectangle is {0}",rectFour.GetRect());
            Console.WriteLine("Area of fifth rectangle is {0}",rectFifth.GetRect());
            Console.WriteLine("Area of sixth rectangle is {0}",rectSixth.GetRect());
        }
    }
}
