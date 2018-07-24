using System;

namespace PropertyClassExample
{
    public class StartUp
    {
        public static void Main()
        {
            Properties properties = new Properties();
            Console.WriteLine(properties.Name);
            properties.Age = 40;
            Console.WriteLine("My age is " + properties.Age);
        }
    }
}
