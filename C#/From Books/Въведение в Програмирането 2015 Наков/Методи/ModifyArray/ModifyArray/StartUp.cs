using System;

namespace ModifyArray
{
    public class StartUp
    {
        public static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;

            Console.Write("In ModifyArray() the param is : ");
            PrintArray(arrParam);
        }

        public static void PrintArray(int[] arrParam)
        {
            int length = arrParam.Length;
            Console.Write("[");
            if (length > 0)
            {
                Console.Write(arrParam[0].ToString());
                for (int i = 1; i < length; i++)
                {
                    Console.Write(", {0} ",arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }

        public static void Main()
        {
            int[] arrArg = new int[] { 1, 2, 3 };

            Console.Write("Before ModifyArray() the argument is : ");
            PrintArray(arrArg);

            //Modifying the array's arguments
            ModifyArray(arrArg);

            Console.Write("After ModifyArray() the argument is : ");
            PrintArray(arrArg);
        }
    }
}
