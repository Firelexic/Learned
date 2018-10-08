using System;

namespace PointExample
{
    class StartUp
    {
        static void Main()
        {
            Point myPoint = new Point(2, 3);

            double myPointXCoordinate = myPoint.X;
            double myPointYCoordinate = myPoint.Y;

            Console.WriteLine("The X coordinate is : " + myPointXCoordinate);
            Console.WriteLine("The Y coordinate is : " + myPointYCoordinate);
        }
    }
}
