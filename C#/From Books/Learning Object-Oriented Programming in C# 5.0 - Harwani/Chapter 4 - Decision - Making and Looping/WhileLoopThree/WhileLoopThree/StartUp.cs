using System;

namespace WhileLoopThree
{
    public class StartUp
    {
        public static void Main()
        {
            int k, m, n;
            Console.WriteLine("Enter the beginning" +
                " and ending limits of the sequence number you wish to print");
            Console.WriteLine("Enter a start : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end");
            n = Convert.ToInt32(Console.ReadLine());
            k = m;
            Console.WriteLine("The sequence numbers from" +
                " {0} to {1} are : ",m,n);

            while (k <= n)
            {
                Console.WriteLine(k);
                k++;
            }
        }
    }
}
