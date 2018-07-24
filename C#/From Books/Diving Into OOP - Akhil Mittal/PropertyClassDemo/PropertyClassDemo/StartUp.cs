using System;

namespace PropertyClassDemo
{
    public class StartUp
    {
        public static void Main()
        {
            Protperty properies = new Protperty();
            Console.WriteLine(properies.Name);
            Console.WriteLine("My age is  : " + properies.Age);
        }
    }
}
