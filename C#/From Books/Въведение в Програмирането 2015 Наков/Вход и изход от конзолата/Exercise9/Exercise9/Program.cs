using System;

namespace Exercise9
{
    public class Program
    {
       public static void Main()
        {
            int highNumber = 0;
            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > highNumber)
                {
                    highNumber = number;
                }

            }
            Console.WriteLine(highNumber);
        }
    }
}
