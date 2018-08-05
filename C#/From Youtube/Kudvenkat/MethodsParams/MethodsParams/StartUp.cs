using System;

namespace MethodsParams
{
    public class StartUp
    {
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }

        public static void Calculate(int FN, int SN, out int Sum,out int Product)
        {
            Sum = FN + SN;
            Product = FN + SN;
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements ",Numbers.Length);
            foreach (var elemenet in Numbers)
            {
                Console.WriteLine(elemenet);
            }
        }

        public static void Main()
        {
            int Total = 0;
            int Product = 0;

            Calculate(10, 20, out Total, out Product);

            Console.WriteLine("Sum = {0} && Product = {1}",Total,Product);


            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            ParamsMethod(1,2,3,4,5,6);
            
        }

    }
}
