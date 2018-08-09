using System;

namespace ThirdExercise
{
    public class StartUp
    {
        public static void Main()
        {

            Console.WriteLine("Add length of array1");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Add length of array2");
            int m = int.Parse(Console.ReadLine());

            char[] symbolArray1 = new char[n];
            char[] symbolArray2 = new char[m];
            

            if (symbolArray1.Length == symbolArray2.Length)
            {
                Console.WriteLine("Add elements in symbolArray1 with {0} elements",n);
                for (int index = 0; index < symbolArray1.Length; index++)
                {
                    symbolArray1[index] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Add elements in symbolArray2 with {0} elements",m);
                for (int index = 0; index < symbolArray2.Length; index++)
                {
                    symbolArray2[index] = char.Parse(Console.ReadLine());
                }
                for (int index = 0; index < symbolArray1.Length; index++)
                {
                    if (symbolArray1[index] != symbolArray2[index])
                    {
                        int number = (int)symbolArray1[index];
                        int numbertwo = (int)symbolArray2[index];
                        if (number < numbertwo)
                        {
                            Console.WriteLine("SymbolArray1 is before symbolArray2");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("SymbolArray2 is before symbolArray1");
                            break;
                        }
                    }
                    if ((index + 1) == symbolArray1.Length)
                    {
                        Console.WriteLine("They are equals");
                    }
                    
                    
                
                }

            }
            else
            {
                if (symbolArray1.Length > symbolArray2.Length)
                {
                    Console.WriteLine("SymbolArray2 is before symbolArray1");
                }
                else
                {
                    Console.WriteLine("SymbolArray1 is before symbolArray2");
                }
            }
        }
    }
}
