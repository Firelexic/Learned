using System;

namespace StringFormatForInt
{
    class StringFormatForInt
    {
        static void Main()
        {
            Console.WriteLine(String.Format("{0:00000}", 15));
            Console.WriteLine(String.Format("{0:00000}", -15));


            //Align number to the right or left
            Console.WriteLine(String.Format("{0,5}", 15));            
            Console.WriteLine(String.Format("{0,-5}", 15));           
            Console.WriteLine(String.Format("{0,5:000}", 15));        
            Console.WriteLine(String.Format("{0,-5:000}", 15));           
        }
    }
}
