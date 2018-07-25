using System;

namespace PropExamle
{
    public class StartUp
    {
        public static void Main()
        {
            Properties properties = new Properties();
            properties.Name = "Akhil";
            properties.Age = 40;
            Console.WriteLine(properties.Name);
            Console.WriteLine(properties.Age);
        }
    }
}
