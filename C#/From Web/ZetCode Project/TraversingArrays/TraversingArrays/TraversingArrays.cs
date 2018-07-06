using System;

namespace TraversingArrays
{
    class TraversingArrays
    {
        static void Main()
        {
            string[] planets = {"Mercury","Venus","Mars",
            "Earth","Jupiter","Saturn","Uranus","Neptune","Pluto"};

            for (int i = 0; i < planets.Length; i++)
            {
                Console.WriteLine(planets[i]);
            }
            Console.WriteLine("--------------------------");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
