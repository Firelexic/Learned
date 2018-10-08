using System;

namespace ClassExampleSecond
{
    class StartUp
    {
        public static void Main()
        {
            Dog dog = new Dog();
            Console.WriteLine("Dog's name is : " + dog.Name);
            Console.WriteLine("Dog's age is : " + dog.Age);
            Console.WriteLine("Dog's length is : " + dog.Length);
            Console.WriteLine("Dog's is male : " + dog.IsMale);
        }
    }
}
