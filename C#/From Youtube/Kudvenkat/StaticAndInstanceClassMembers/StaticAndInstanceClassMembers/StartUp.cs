using System;

namespace StaticAndInstanceClassMembers
{
    public class StartUp
    {
        public static void Main()
        {
            int radiusS = int.Parse(Console.ReadLine());
            Circle circleOne = new Circle(radiusS);
            float area = circleOne.CalculateArea();
            Console.WriteLine("Area = {0}",area);

            Circle circleTwo = new Circle(6);
            float areaTwo = circleTwo.CalculateArea();
            Console.WriteLine("Area = {0}",areaTwo);

            
        }
    }
}
