using System;

namespace AbstractClasses
{
    public class StartUp : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Hello ");
        }

        public static void Main()
        {
            StartUp startUser = new StartUp();
            startUser.Print();
        }
    }
}
