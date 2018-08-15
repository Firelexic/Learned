using System;
using System.Threading;
using System.Globalization;
namespace CultureInfoExample
{
    public class StartUp
    {
        public static void Main()
        {
            DateTime date = new DateTime(2009, 10, 23, 15, 30, 22);
            Thread.CurrentThread.CurrentCulture =
                CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}",1234.56);
            Console.WriteLine("{0:D}", date);

            Thread.CurrentThread.CurrentCulture =
                CultureInfo.GetCultureInfo("bg-BG");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", date);
        }
    }
}
