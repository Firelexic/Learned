using System;

namespace NullableType
{
    public class StartUp
    {
        public static void Main()
        {
            int i = 5;
            int? ni = i;
            Console.WriteLine(ni);

            Console.WriteLine(ni.HasValue);
            i = ni.Value;
            Console.WriteLine(i);

            ni = null;
            Console.WriteLine(ni.HasValue);
            i = ni.GetValueOrDefault();
            Console.WriteLine(i);
        }
    }
}
