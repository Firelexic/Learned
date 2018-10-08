using System;

namespace CoordianteExample
{
    public class StartUp
    {
        public static void Main()
        {
            Point myPoint = new Point(2, 3);
            Console.WriteLine($"My point have x with {myPoint.X} and y = {myPoint.Y}");
        }
    }
}
