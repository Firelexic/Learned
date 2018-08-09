using System;

namespace TwoDimensionArray
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

            Console.WriteLine(matrix[0,1]);
        }
    }
}
