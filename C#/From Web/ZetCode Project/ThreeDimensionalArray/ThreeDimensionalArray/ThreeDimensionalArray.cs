using System;

namespace ThreeDimensionalArray
{
    class ThreeDimensionalArray
    {
        static void Main()
        {
            int[,,] n3 =
            {
                { { 1,2,3} },
                { { 4,5,6} },
                { {7,8,9 } },
            };

            int d1 = n3.GetLength(0);
            int d2 = n3.GetLength(1);
            int d3 = n3.GetLength(2);

            for (int i = 0; i < d1; i++)
            {
                for (int j = 0; j < d2; j++)
                {
                    for (int k = 0; k < d3; k++)
                    {
                        Console.Write(n3[i,j,k] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
