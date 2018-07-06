using System;

namespace TwoDimensionalArray
{
    class TwoDimensionalArray
    {
        static void Main()
        {
            int[,] twodim = new int[,] { { 1, 2, 3 }, { 1, 2, 3 } };
            int d1 = twodim.GetLength(0);
            int d2 = twodim.GetLength(1);

            for (int i = 0; i < d1; i++)
            {
               
                for (int j = 0; j < d2; j++)
                {
                    Console.Write(twodim[i,j]);
                    
                }
                Console.WriteLine();
            }
        }
    }
}
