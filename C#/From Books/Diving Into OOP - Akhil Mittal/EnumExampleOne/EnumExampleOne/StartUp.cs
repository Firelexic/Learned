using System;

namespace EnumExampleOne
{
    enum Color : byte
    {
        Yellow,
        Blue,
        Brown,
        Green
    }

    public class StartUp
    {

        public static void Main()
        {
            int myColor = 2;
            if (myColor == (int)Color.Green)
            {
                Console.WriteLine("my color");
            }
        }
    }
}
