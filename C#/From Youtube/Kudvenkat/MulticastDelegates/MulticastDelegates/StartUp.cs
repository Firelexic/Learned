using System;

namespace MulticastDelegates
{
    public delegate void SimpleDelegate();

    public class StartUp
    {
        public static void Main()
        {
            SimpleDelegate del = new SimpleDelegate(SimpleMethodOne);
            del += SimpleMethodTwo;
            del();
            del += SimpleMethodThree;
            del();
        }

        public static void SimpleMethodOne()
        {
            Console.WriteLine("SimpleMethodOne Invoked !");
        }

        public static void SimpleMethodTwo()
        {
            Console.WriteLine("SimpleMethodTwo Invoked !");
        }

        public static void SimpleMethodThree()
        {
            Console.WriteLine("SimpleMethodThree Invoked !");
        }
    }
}
