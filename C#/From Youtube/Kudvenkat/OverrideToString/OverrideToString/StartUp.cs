using System;

namespace OverrideToString
{
    public class StartUp
    {
        public static void Main()
        {
            int number = 10;

            Console.WriteLine(number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Console.WriteLine(C1.ToString());
        }
    }
}
