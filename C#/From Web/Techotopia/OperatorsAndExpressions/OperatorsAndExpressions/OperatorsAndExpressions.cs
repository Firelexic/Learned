using System;

namespace OperatorsAndExpressions
{
    class OperatorsAndExpressions
    {
        static void Main()
        {
            //Assigns
            int x;
            int y = 10;
            int z = 10;
            x = y + z;
            Console.WriteLine(x);
            x = y = z = 22;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            //Arithmetic Operators
            x = y * 10 + z - 5 / 4;
            z = x + y;
            x = y - z;
            y = z % x;
            z = x * y;
            //Compound Assignment Operators
            x += y; // x = x + y
            x -= y; // x = x - y
            x *= y; // x = x * y
            x /= y; // x = x / y;
            //Increment and Decrement
            //Increase value of variable by 1
            x++; // same as x = x + 1
            //Decrease value of variable by 1
            x--;//same as x = x-1


            //Logical(Boolean) Operators
            //NOT(!)
            bool flag = true;
            bool secondFlag;

            secondFlag = !flag;
            Console.WriteLine(secondFlag);


            //OR(||)
            if ((10 < 20) || (20 <10))
                {
                Console.WriteLine("Expression is true");
            }

            //AND(&&)
            if ((10 < 20) && (20 < 10))
            {
                Console.WriteLine("Expression is true");
            }

            //XOR(^)
            if ((10 < 20) ^ (20 < 10))
            {
                Console.WriteLine("Expression is true");
            }
            

        }
    }
}
