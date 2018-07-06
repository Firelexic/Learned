using System;

namespace Planets
{
    class Planets
    {
        static void Main()
        {
            string[] planets = {"Mercury", "Venus", "Earth", "Mars","Jupiter","Saturn",
            "Uranus","Pluto"};

            for (int i = 0; i < planets.Length; i++)
            {
                Console.WriteLine(planets[i]);
            }

            Console.WriteLine("In reverse : ");

            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(planets[i]);
            }
        }
    }
}
