using System;

namespace SecondExercise
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter radius: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("P is {0} and S is {1}", 2 * Math.PI * r, Math.PI * r * r);
        }
    }
}
