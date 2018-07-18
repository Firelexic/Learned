using System;

namespace Overload
{
    class StartUp
    {
        public static double ComputeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * 3.141593);
        }
        
        public static double ComputeArea(double width,double height)
        {
            return (width * height);
        }

        public static double ComputeArea(double width,double height,char letter)
        {
            return ((width / 2) * height);
        }
        static void Main()
        {
            double num;
            double area;


            Console.WriteLine("Enter Dimension in Feet:");
            num = double.Parse(Console.ReadLine());

            area = ComputeArea(num);
            Console.WriteLine($"Circle area = {area} ");

            area = ComputeArea(num, num);
            Console.WriteLine($"Square area  = {area} ");

            area = ComputeArea(num, num, 'T');
            Console.WriteLine($"Triangle area = {area} ");
        }
    }
}
