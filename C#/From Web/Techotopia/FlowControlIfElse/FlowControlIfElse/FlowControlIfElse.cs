using System;

namespace FlowControlIfElse
{
    class FlowControlIfElse
    {
        static void Main()
        {
            //First
            int x = 10;
            if (x > 9)
            {
                Console.WriteLine("X is greater than 9!");
            }

            //Second
            x = 10;
            if (x > 9)
            {
                Console.WriteLine("X is greater than 9!");
            }
            else
            {
                Console.WriteLine("X is less than 9!");

            }

            //Third
            int y = 9;
            if (y == 10)
            {
                Console.WriteLine("y is 10");
            }
            else if (y == 9)
            {
                Console.WriteLine("y is 9");
            }
            else if (y == 8)
            {
                Console.WriteLine("y is 8");
            }
           

        }
    }
}
