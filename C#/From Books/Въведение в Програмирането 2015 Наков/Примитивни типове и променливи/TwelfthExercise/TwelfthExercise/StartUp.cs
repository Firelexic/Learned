using System;

namespace TwelfthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastNmae = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstName} {lastNmae} {age} {gender} {id}");
        }
    }
}
