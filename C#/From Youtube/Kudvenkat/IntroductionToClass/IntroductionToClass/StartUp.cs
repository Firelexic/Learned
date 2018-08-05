using System;

namespace IntroductionToClass
{
    public class StartUp
    {
        public static void Main()
        {
            Customer customerOne = new Customer(
                "Mixail", "Salkin");

            customerOne.PrintFullName();
           
        }
    }
}
