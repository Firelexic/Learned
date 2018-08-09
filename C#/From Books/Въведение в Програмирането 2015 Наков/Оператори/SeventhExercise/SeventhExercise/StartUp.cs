using System;

namespace SeventhExercise
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Add weight of a man : ");
            int weightOnEarth = int.Parse(Console.ReadLine());
            double weightOnMoon = weightOnEarth * 0.17;
            Console.WriteLine("Weight on the Moon = {0}",weightOnMoon);
        }
    }
}
