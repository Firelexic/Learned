using System;

namespace TwoDimensionArrayExample
{
    public class StartUp
    {
        public static void Main()
        {
            int[,] matrix =
            {
                {1,2,3,4 },
                {5,6,7,8 },
            };
            Console.Write(matrix[0,0]);
            Console.Write(matrix[0,1]);
            Console.Write(matrix[0,2]);
            Console.WriteLine(matrix[0,3]);
            Console.Write(matrix[1,0]);
            Console.Write(matrix[1,1]);
            Console.Write(matrix[1,2]);
            Console.WriteLine(matrix[1,3]);

        }
    }
}
