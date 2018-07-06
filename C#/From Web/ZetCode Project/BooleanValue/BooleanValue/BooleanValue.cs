using System;

namespace BooleanValue
{
    class BooleanValue
    {
        static void Main(string[] args)
        {
            bool male = false;

            Random random = new Random();
            male = Convert.ToBoolean(random.Next(0, 2));

            if (male)
            {
                Console.WriteLine("We will use name John");
            }
            else
            {
                Console.WriteLine("We will use name Victoria");
            }
        }
    }
}
