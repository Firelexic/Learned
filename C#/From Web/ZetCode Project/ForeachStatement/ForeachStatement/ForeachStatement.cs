using System;

namespace ForeachStatement
{
    class ForeachStatement
    {
        static void Main()
        {
            string[] planets = {"Mercury", "Venus",
            "Earth", "Mars", "Jupiter", "Saturn",
            "Uranus", "Neptune" };

            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
