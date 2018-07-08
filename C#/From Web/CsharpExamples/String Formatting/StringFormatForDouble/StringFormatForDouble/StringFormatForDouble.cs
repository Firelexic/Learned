using System;

namespace StringFormatForDouble
{
    class StringFormatForDouble
    {
        static void Main()
        {
            //just two decimal places
            Console.WriteLine(String.Format("{0:0.00}",123.4567));
            Console.WriteLine("{0:0.0}",1234.1234);
            Console.WriteLine(String.Format("{0:0.00}",123.4));
            Console.WriteLine(String.Format("{0:0.00}",123.0));

            Console.WriteLine("------------------------------");

            // max. two decimal places
            Console.WriteLine(String.Format("{0:0.##}", 123.4567));   
            Console.WriteLine(String.Format("{0:0.##}", 123.4));         
            Console.WriteLine(String.Format("{0:0.##}", 123.0));

            Console.WriteLine("-------------------------------");
            //at least two digits before decimal point
            Console.WriteLine(String.Format("{0:0.0}",123.4567));

            //Thousands separator
            Console.WriteLine(String.Format("{0:0,0.0}",12345.67));
            Console.WriteLine(String.Format("{0:0,0}",12345.67));

            
        }
    }
}
