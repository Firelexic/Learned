using System;

namespace SecondExercise
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Add arrayOne length");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Add arrayTwo length");
            int m = int.Parse(Console.ReadLine());
           
            int[] array1 = new int[n];
            int[] array2 = new int[m];
            bool isEqual = true;
            if (array1.Length == array2.Length)
            {


                Console.WriteLine("Add element of arrayOne with {0} elements", n);
                for (int index = 0; index < array1.Length; index++)
                {
                    array1[index] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Add element of arrayTwo with {0} elements", m);

                for (int index = 0; index < array2.Length; index++)
                {
                    array2[index] = int.Parse(Console.ReadLine());
                }

                if (array1.Length == array2.Length)
                {
                    Console.WriteLine("Arrays length are equals");

                    for (int index = 0; index < array2.Length; index++)
                    {
                        if (array2[index] != array1[index])
                        {

                            isEqual = false;
                            break;
                        }
                    }

                }
                Console.WriteLine("Arrays elements are equal - {0}", isEqual);
            }
            if (array1.Length != array2.Length)
            {
                Console.WriteLine("The length of arrays are not equal so their elements will not be equals");
            }
        }
    }
}
