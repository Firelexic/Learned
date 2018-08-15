using System;

namespace ExampleFirst
{
    public class StartUp
    {
        public static void Main()
        {
            int weight = 700;
            Console.WriteLine(weight >= 500);

            char gender = 'm';
            Console.WriteLine(gender <= 'f');

            double colorWaveLength = 1.630;
            Console.WriteLine(colorWaveLength > 1.621);

            int a = 5;
            int b = 7;
            bool condition = (b > a) && (a + b < a * b);
            Console.WriteLine(condition);

            Console.WriteLine('B' == 'A' + 1);
        }
    }
}
