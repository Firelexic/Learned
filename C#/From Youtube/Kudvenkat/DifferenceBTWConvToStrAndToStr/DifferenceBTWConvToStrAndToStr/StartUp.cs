using System;

namespace DifferenceBTWConvToStrAndToStr
{
    public class StartUp
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            string str = Convert.ToString(C1);
            Console.WriteLine(str);
        }
    }
}
