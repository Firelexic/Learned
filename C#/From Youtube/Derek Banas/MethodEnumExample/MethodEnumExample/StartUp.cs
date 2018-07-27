using System;

namespace MethodEnumExample
{
    enum CarColor: byte
    {
        Orange = 1,
        Blue,
        Green,
        Red,Yellow
    }

   

    public class StartUp
    {
        public static void Main()
        {
            int numOne = 10;
            int numTwo = 20;

            Console.WriteLine("Before Swap numOne : {0} , NumTwo = {1}",numOne,numTwo);
            Swap(ref numOne,ref numTwo);

            Console.WriteLine("After Swap numOne : {0} , numTwo : {0}",numOne,numTwo);

            PrintInfo(zipCode: 15177, name: "Derek Banas");

            Console.WriteLine("5 + 4.5 = {0}",GetSum(5.0,4.50));

        }
        
        public static void Swap(ref int numOne,ref int numTwo)
        {
            int temp = numOne;
            numOne = numTwo;
            numTwo = temp;
        }

        static void PrintInfo(string name,int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}",name,zipCode);
        }

        static double GetSum(double x = 1,double y = 1)
        {
            return x + y; 
        }

    }
}
