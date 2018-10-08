using System;

namespace ConstructorWithParams
{
    public class StartUp
    {
        public static void Main()
        {
            Dog myDog = new Dog("Bobi", 2, 0.4);

            Console.WriteLine("My Dog " + myDog.name);
        }
    }
}
