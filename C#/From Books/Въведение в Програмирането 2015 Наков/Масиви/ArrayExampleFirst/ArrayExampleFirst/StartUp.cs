using System;

namespace ArrayExampleFirst
{
    public class StartUp
    {
        public static void Main()
        {
            int[] myArray = new int[6];
            int[] myNewArray = { 1, 2, 3, 4, 5, 6 };
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"

            };

            myArray[4] = 100;
            Console.WriteLine(myArray[4]);

            int[] arr = new int[6];
            arr[1] = 1;
            arr[5] = 5;

            int[] secondArray = new int[5];
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine(secondArray[i]);
            }
                
        }
    }
}
