using System;

namespace ArithmeticOperator
{
    public class StartUp
    {
        public static void Main()
        {
            int a = 5;
            int b = 3;
            int add = a + b;
            int sub = a - b;
            int mult = a * b;
            int div = a / b;
            int rem = a % b;
            double remdr = 5.123 % 3.123;
            int c = +a; 
            int d = -a; 
            Console.WriteLine("Addition of {0} and {1} is {2}", a, b, add);
            Console.WriteLine("Subtracting {0} from {1} results into {2}", b, a, sub);
            Console.WriteLine("Multiplication of {0} and {1} is {2}", a, b, mult);
            Console.WriteLine("Dividing {0} by {1} results into {2}", a, b, div);
            Console.WriteLine("Remainder when integer {0} is divided by {1} is {2}", a, b, rem);
            Console.WriteLine("Remainder when float 5.123 is divided by 3.123 is {0}", remdr);
            Console.WriteLine("Sign Operators - Value in c variable is {0} and in d is {1}", c, d);
            int e = a + ++b;
            Console.WriteLine("Pre-increment operation. Value in a is {0}, b is {1} and e is {2}", a, b, e);
            b--;
            int f = a + b++;
            Console.WriteLine("Post increment operation. Value in a is {0}, b is {1} and f is { 2}", a, b, f);
          
        }
    }
}
