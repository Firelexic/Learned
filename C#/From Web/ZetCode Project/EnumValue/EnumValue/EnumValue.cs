﻿using System;

namespace EnumValue
{
    class EnumValue
    {
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main()
        {
            Days day = Days.Monday;
            if (day == Days.Monday)
            {
                Console.WriteLine("It is Monday");
            }

            Console.WriteLine(day);

            foreach (int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i);
            }
        }
    }
}
