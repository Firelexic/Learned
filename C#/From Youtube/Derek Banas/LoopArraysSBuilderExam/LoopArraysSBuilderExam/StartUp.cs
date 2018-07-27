using System;
using System.Globalization;
using System.Text;

namespace LoopArraysSBuilderExam
{
    public class StartUp
    {
        public static void Main()
        {
            int[] randNumb = { 1, 4, 9, 2 };
            Array.Sort(randNumb);
            PrintArray(randNumb, "Foreach");
            PrintLine();

            //ArrayReverse
            Array.Reverse(randNumb);
            PrintArray(randNumb, "Foreach");

            PrintLine();

            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startIn = 0;
            int length = 2;

            Array.Copy(srcArray, startIn, destArray, startIn, length);

            PrintArray(destArray, "Copy");


            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            srcArray.CopyTo(anotherArray, 5);
             foreach (int element in anotherArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("=====---===-----------========");
            int[] numArray = { 1, 11, 22 };

            Console.WriteLine(">  10 : {0}",Array.Find(numArray,GreaterthanTen));

            Console.WriteLine("---------------------------------");
            //StringBuilder
            StringBuilder sb = new StringBuilder("Random Text");

            StringBuilder sbTwo =new StringBuilder("More Stuff that is important", 256);

            Console.WriteLine("Capacity : {0}",sb.Capacity);
            Console.WriteLine("Capacity : {0}",sbTwo.Capacity);

            sbTwo.AppendLine("More important text");

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            string bestCust = "Bob Smith";
            sbTwo.AppendFormat(enUS, "Best Customer : {0}",bestCust);
            Console.WriteLine(sbTwo.ToString());

        }

        private static bool GreaterthanTen(int val)
        {
            return val > 10;
        }
        

        static void PrintArray(int[] intArray,string message)
        {
            foreach (int element in intArray)
            {
                Console.WriteLine($"{message} = {element}");
            }
        }

        static void PrintLine()
        {
            Console.WriteLine("{0}",new string('=',12));
        }
    }
}
