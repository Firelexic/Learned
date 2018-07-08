using System;

namespace StringFormatForDateTime
{
    class StringFormatForDateTime
    {
        static void Main()
        {
            //create date time 2008-03-09 16:05:07.123
            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
            Console.WriteLine(dt);
            Console.WriteLine(String.Format("{0:y}",dt));
            Console.WriteLine(String.Format("{0:y yy yyy yyyy}", dt));
            Console.WriteLine(String.Format("{0:M MM MMM MMMM}", dt));  
            Console.WriteLine(String.Format("{0:d dd ddd dddd}", dt));  
            Console.WriteLine(String.Format("{0:h hh H HH}", dt));  
            Console.WriteLine(String.Format("{0:m mm}", dt));  
            Console.WriteLine(String.Format("{0:s ss}", dt)); 
            Console.WriteLine(String.Format("{0:f ff fff ffff}", dt));  
            Console.WriteLine(String.Format("{0:F FF FFF FFFF}", dt));  
            Console.WriteLine(String.Format("{0:t tt}", dt));
            Console.WriteLine(String.Format("{0:z zz zzz}", dt));

            // date separator in german culture is "." (so "/" changes to ".")
            Console.WriteLine(String.Format("{0:d/M/yyyy HH:mm:ss}", dt)); // "9/3/2008 16:05:07" - english (en-US)
            Console.WriteLine(String.Format("{0:d/M/yyyy HH:mm:ss}", dt)); // "9.3.2008 16:05:07" - german (de-DE)

            Console.WriteLine("-------------------------------");
            Console.WriteLine(String.Format("{0:t}", dt));  // "4:05 PM"                         ShortTime
            Console.WriteLine(String.Format("{0:d}", dt));  // "3/9/2008"                        ShortDate
            Console.WriteLine(String.Format("{0:T}", dt));  // "4:05:07 PM"                      LongTime
            Console.WriteLine(String.Format("{0:D}", dt));  // "Sunday, March 09, 2008"          LongDate
            Console.WriteLine(String.Format("{0:f}", dt));  // "Sunday, March 09, 2008 4:05 PM"  LongDate+ShortTime
            Console.WriteLine(String.Format("{0:F}", dt));  // "Sunday, March 09, 2008 4:05:07 PM" FullDateTime
            Console.WriteLine(String.Format("{0:g}", dt));  // "3/9/2008 4:05 PM"                ShortDate+ShortTime
            Console.WriteLine(String.Format("{0:G}", dt));  // "3/9/2008 4:05:07 PM"             ShortDate+LongTime
            Console.WriteLine(String.Format("{0:m}", dt));  // "March 09"                        MonthDay
            Console.WriteLine(String.Format("{0:y}", dt));  // "March, 2008"                     YearMonth
            Console.WriteLine(String.Format("{0:r}", dt));  // "Sun, 09 Mar 2008 16:05:07 GMT"   RFC1123
            Console.WriteLine(String.Format("{0:s}", dt));  // "2008-03-09T16:05:07"             SortableDateTime
            Console.WriteLine(String.Format("{0:u}", dt));
        }
    }
}
