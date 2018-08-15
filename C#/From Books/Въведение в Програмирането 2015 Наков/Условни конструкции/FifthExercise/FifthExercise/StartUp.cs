using System;

namespace FifthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Нула");
            }
            else if (number == 1)
            {
                Console.WriteLine("Едно");
            }
            else if (number == 2)
            {
                Console.WriteLine("Две");
            }
            else if (number == 3)
            {
                Console.WriteLine("Три");
            }
            else if (number == 4)
            {
                Console.WriteLine("Четири");
            }
            else if (number == 5)
            {
                Console.WriteLine("Пет");
            }
            else if (number == 6)
            {
                Console.WriteLine("Шест");
            }
            else if (number == 7)
            {
                Console.WriteLine("Седем");
            }
            else if (number == 8)
            {
                Console.WriteLine("Осем");
            }
            else if (number == 9)
            {
                Console.WriteLine("Девет");
            }
            else
            {
                Console.WriteLine("Числото е над 9");
            }
            
        }
    }
}
