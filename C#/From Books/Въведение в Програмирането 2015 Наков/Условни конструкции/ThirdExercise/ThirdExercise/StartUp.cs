using System;

namespace ThirdExercise
{
    public class StartUp
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine("Number1 is greater.");
                }
                
            }
            else if (number2 > number1)
            {
                if (number2 > number3)
                {
                    Console.WriteLine("Number2 is greater.");
                }
                else 
                {
                    Console.WriteLine("Number 3 is greater.");
                }
            }
            
        }
    }
}
