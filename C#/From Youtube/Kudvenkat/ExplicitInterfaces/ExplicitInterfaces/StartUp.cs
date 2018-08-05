using System;

namespace ExplicitInterfaces
{
    public class StartUp : IOne,ITwo
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("IOne Interface Method !");
        }

        public static void Main()
        {
            StartUp start = new StartUp();
            start.InterfaceMethod();
        }
    }
}
