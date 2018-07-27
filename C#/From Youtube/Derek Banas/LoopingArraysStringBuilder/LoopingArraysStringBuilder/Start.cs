using System;

namespace LoopingArraysStringBuilder
{
    public class Start
    {
        public static void Main()
        {
            //implicit cast
            var intValue = 1234;

            Console.WriteLine("intVal Type : {0}", intValue.GetType());


            Console.WriteLine("======================================");
            //Arrays
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            string[] customers = { "Bob", "Sally", "Sue" };
            var employyes = new string[] { "Mike", "Paul", "Rick" };

            object[] randomArray = { "Paul", 45, 1.234 };

            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            Console.WriteLine("Array Size : {0}", randomArray.Length);
            Console.WriteLine("======================================");
            Console.WriteLine("Elements in Array");

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }

            string[,] custNames = new string[2, 2] { {"Bob","Sally" }, {"Smith","Marks" } };
            Console.WriteLine("MD Value : {0}",custNames.GetValue(1,1));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(0); j++)
                {
                    Console.WriteLine("{0}",custNames[i,j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
