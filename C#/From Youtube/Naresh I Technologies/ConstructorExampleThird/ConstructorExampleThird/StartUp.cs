using System;

namespace ConstructorExampleThird
{
    public class StartUp
    {
        public static void Main()
        {
            First first = new First();
            First first1 = new First();
            First first2 = new First();
            First first3 = new First();

            Console.WriteLine(first.x + first1.x + first2.x + first3.x);
            Console.WriteLine(first.x + " " + first1.x + " " + first2.x + " " + first3.x);
        }
    }
}
