using System;

namespace OOPexample
{
    public class StartUp
    {
        public static void Main()
        {
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

            Console.WriteLine("# of Animals : {0}",Animal.GetNumAnimals());
            fox.MakeSound();



            Console.WriteLine("Area of Rectangle : {0}",ShapeMath.GetArea("rectangle",5,6));
        }
    }
}
