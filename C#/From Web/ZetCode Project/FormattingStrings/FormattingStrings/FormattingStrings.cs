using System;

namespace FormattingStrings
{
    class FormattingStrings
    {
        static void Main()
        {
            int oranges = 2;
            int apples = 4;
            int bananas = 3;

            string strOne = "There are {0} oranges, {1} apples and " + "{2} bananas";
            string strTwo = "There are {1} oranges, {2} bananas and " + "{0} apples";

            Console.WriteLine(strOne,oranges,apples,bananas);
            Console.WriteLine(strTwo,apples,oranges,bananas);
        }
    }
}
