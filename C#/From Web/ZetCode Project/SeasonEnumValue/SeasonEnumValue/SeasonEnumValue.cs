using System;

namespace SeasonEnumValue
{
    class SeasonEnumValue
    {
        enum Season : byte
        {
            Spring = 1,
            Summer = 2,
            Autumn = 3,
            Winter = 4,
        }

        static void Main()
        {
            Season seasonOne = Season.Spring;
            Season seasonTwo = Season.Autumn;

            Console.WriteLine(seasonOne);
            Console.WriteLine(seasonTwo);
        }
    }
}
