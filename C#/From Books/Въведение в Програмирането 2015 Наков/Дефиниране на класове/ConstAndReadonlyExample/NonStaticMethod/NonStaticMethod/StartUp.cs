using System;

namespace NonStaticMethod
{
    public class StartUp
    {
        public static void Main()
        {
            Dog dog = new Dog("Sharo", 1);
            dog.PrintInfo();
        }
    }
}
