using System;

namespace FourthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int hexNum = 2015;
            Console.WriteLine("{|0x{0,-8:X|}", hexNum);
            double fractNum = -1.856;
            Console.WriteLine("{|0,-10:f2}|", fractNum);
        }
    }
}
