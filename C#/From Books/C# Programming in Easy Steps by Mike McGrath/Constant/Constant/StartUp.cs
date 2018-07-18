using System;
using System.Collections.Generic;
using System.Linq;

namespace Constant
{
    public class StartUp
    {
        enum Days
        {
            Sat,
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri
        }

        public static void Main()
        {
            const double pi = 3.14;
            var daysType = typeof(Days);

            Console.WriteLine("Pi type : " + pi.GetType());
            Console.WriteLine("Circumference: " + (pi * 3));
            Console.WriteLine("First Name: " + Days.Sat);
            Console.WriteLine("1st index: " + (int)Days.Sat);

            string name = Enum.GetName(daysType, 1);
            Console.WriteLine("2nd Index: " + name);
            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("Contains Mon?: " + flag);

        }
    }
}
