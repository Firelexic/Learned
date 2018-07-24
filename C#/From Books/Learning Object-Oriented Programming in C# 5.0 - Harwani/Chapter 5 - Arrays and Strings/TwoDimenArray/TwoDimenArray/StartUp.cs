using System;

namespace TwoDimenArray
{
    public class StartUp
    {
        public static void Main()
        {
            int[,] p = new int[2, 4];
            Console.WriteLine("Enter elements ffor an array of order 2 x 4 : ");
            for (int i = 0; i < 2 ; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    p[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"array[{i},{j}] = {p[i,j]}");
                }
            }
        }
    }
}
