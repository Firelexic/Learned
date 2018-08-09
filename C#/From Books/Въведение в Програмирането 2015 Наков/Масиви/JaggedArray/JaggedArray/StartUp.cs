using System;

namespace JaggedArray
{
    public class StartUp
    {
        public static void Main()
        {
            int[][] jaggedArray;
            jaggedArray = new int[2][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];

            int[][] myJaggedArray =
            {
                new int[] {5,7,2 },
                new int[] {10,20,40 },
                new int[] {3,25 }
            };

            Console.WriteLine(myJaggedArray[1][0]);

            int[][,] jaggedOfMulti = new int[2][,];
            jaggedOfMulti[0] = new int[,] { { 5, 15 }, { 125, 206 } };
            jaggedOfMulti[1] = new int[,] { { 3, 4, 5 }, { 7, 8, 9 } };
        }
    }
}
