using System;

namespace TypeOf
{
   public class Program
    {
      public static void Main()
      {
            Console.WriteLine("Size of int is {0}",sizeof(int));
            Console.WriteLine("Size of char is {0}",sizeof(char));
            Console.WriteLine("Size of float is {0}",sizeof(float));
            Console.WriteLine("Size of double is {0}",sizeof(double));
            Console.WriteLine("Size of int64 is {0}",sizeof(Int64));
            Console.WriteLine("Type of int is {0}",typeof(int));
            Console.WriteLine("Type of char is {0}",typeof(char));
            Console.WriteLine("Type of float is {0}",typeof(float));
            Console.WriteLine("Type of double is {0}",typeof(double));
      }
    }
}
