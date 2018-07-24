using System;

namespace PropertyNextExample
{
    public class StartUp
    {
        public static void Main()
        {
            Properties properties = new Properties();
            properties.Name = "Akhil";
            Console.WriteLine(properties.Name);
            properties.Age = 40;
            Console.WriteLine(properties.Age);
        }
    }
}
