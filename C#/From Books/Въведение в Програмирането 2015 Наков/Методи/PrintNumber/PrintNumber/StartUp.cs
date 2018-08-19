using System;

namespace PrintNumber
{
    public class StartUp
    {
        public static void PrintNumber(int numberParam)
        {
            //Modifying the primitive - type parameter
            numberParam = 5;

            Console.WriteLine("in PrintNumber() method, after the " + "modification,numberParam is {0} : ",numberParam);
        }

        public static void Main()
        {
            int numberArg = 3;

            //Copying the value 3 of the argument numberArg to the 
            //parameter numberParam
            PrintNumber(numberArg);
            Console.WriteLine("in the Main() method number is : " + numberArg);
        }
    }
}
