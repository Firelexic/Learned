using System;

namespace FourthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int midleNumber = 0;
            int highNumber = 0;
            int lowNumber = 0;

            if (number1 > number2)
            {
                
                if (number2 > number3)
                {
                    highNumber = number1;
                    midleNumber = number2;
                    lowNumber = number3;
                    
                }
                else
                {
                    if (number1 > number3)
                    {
                        highNumber = number1;
                        midleNumber = number3;
                        lowNumber = number2;
                    }
                    else
                    {
                        highNumber = number3;
                        midleNumber = number1;
                        lowNumber = number2;
                    }
                }
                
            }
            else if (number2 > number3)
            {
                highNumber = number2;
                if (number3 > number1)
                {
                    midleNumber = number3;
                    lowNumber = number1;
                }
                else
                {
                    midleNumber = number1;
                    lowNumber = number3;
                }
            }
            else if (number3 > number1)
            {
                highNumber = number3;
                if (number2 > number1)
                {
                    midleNumber = number2;
                    lowNumber = number1;
                }
                else
                {
                    midleNumber = number1;
                    lowNumber = number2;
                }
            }

            Console.WriteLine("HighNumber = {0}, MidleNumber = {1},LowNumber = {2} ",highNumber,midleNumber,lowNumber);
        }
    }
}
