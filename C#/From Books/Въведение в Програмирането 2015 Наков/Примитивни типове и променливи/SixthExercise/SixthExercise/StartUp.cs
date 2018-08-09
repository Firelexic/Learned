using System;

namespace SixthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            char male = 'm';
            bool isMale = male.Equals('m');
            if (isMale)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are female");
            }
        }
    }
}
