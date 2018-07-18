using System;

namespace OOPInheritance
{
    public class StartUp
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle();
            Triangle cone = new Triangle();

            rect.SetValue(4, 5);
            cone.SetValue(4, 5);

            Console.WriteLine("Rectangle Area : " + rect.Area());
            Console.WriteLine("Triangle Area : " + cone.Area());
        }
    }
}
