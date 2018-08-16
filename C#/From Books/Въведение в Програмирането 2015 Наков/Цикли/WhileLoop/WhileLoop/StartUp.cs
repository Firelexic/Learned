using System;

namespace WhileLoop
{
    public class StartUp
    {
        public static void Main()
        {
            //Initialize the counter
            int counter = 0;

            //Execute the loop body while the loop condition holds
            while (counter <= 9)
            {
                //Print the counter value
                Console.WriteLine("Number : {0}",counter);

                //Increment the counter
                counter++;
            }
        }
    }
}
