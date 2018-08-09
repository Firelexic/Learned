using System;

namespace FourthExercise
{
    public class StartUp
    { 
        static void Main()
        {
            int i;
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int longest = 0;
            int num = 0;
            int[] counter = new int[n];
            int k = 0;
            int l = 1;
            for (i = 0; i < n; i++)
            {
                counter[i] = 1;
                int first = number[i];

                for (int j = l; j < n; j++)
                {
                    int next = number[j];
                    if (first == next)
                    {
                        counter[i]++;
                    }
                }
                if (counter[i] > longest)
                {
                    longest = counter[i];
                    num = number[i];
                }

                k++;//1
                l++;//2

            }
            Console.Write("{");
            for (i = 0; i < n - 1; i++)
            {
                Console.Write(number[i] + ",");
            }
            Console.Write(number[i] + "}");

            Console.Write(" - {");
            for (i = 0; i < longest - 1; i++)
            {
                Console.Write(num + ",");
            }
            Console.Write(num + "}");


            Console.ReadLine();
        }
    }
}
