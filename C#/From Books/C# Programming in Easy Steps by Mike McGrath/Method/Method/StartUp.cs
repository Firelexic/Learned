using System;

namespace Method
{
    public class StartUp
    {
        public static void BodyTempc()
        {
            Console.WriteLine("Body Temperature....");
            Console.WriteLine("Centigrade : 37'C ");
        }

        public static double BodyTempf()
        {
            double temperatre = 98.6;
            return temperatre;
        }

        public static int bodyTempK()
        {
            int temperature = 310;
            return temperature;
        }


        public static void Main()
        {
            BodyTempc();
            Console.WriteLine($"Fahrenheit : {BodyTempf()} K");
            Console.WriteLine($"Kelvin : {bodyTempK()} K");
        }
    }
}
