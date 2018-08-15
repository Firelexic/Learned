using System;

namespace SeventhExercise
{
    public class Program
    {
        public static void Main()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    i--;
                    continue;
                }
                sum = sum + number;
                
            }
            Console.WriteLine(sum);
        }
    }
}
