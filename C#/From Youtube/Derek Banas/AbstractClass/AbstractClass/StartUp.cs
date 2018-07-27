using System;

namespace AbstractClass
{
    public class StartUp
    {
        public static void Main()
        {
            Shape[] shapes =
            {
                new Circle(5),
                new Rectangle(4,5)
            };

            foreach (Shape element in shapes)
            {
                element.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}",element.Name,element.Area());
            }
        }
    }
}
