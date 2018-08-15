using System;

namespace CustomFormatDate
{
    public class StartUp
    {
        public static void Main()
        {
            DateTime date = new DateTime(2009, 10, 23, 15, 30, 22);
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}",date);
            Console.WriteLine("{0:d.MM.yy г.}",date);

            Console.WriteLine("{0:d}", date);
            Console.WriteLine("{0:D}",date);
            Console.WriteLine("{0:t}", date);
            Console.WriteLine("{0:T}", date);
            Console.WriteLine("{0:Y}", date);
            Console.WriteLine("{0:y}", date);
        }
    }
}
