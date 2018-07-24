using System;

namespace OOPexample
{
    public class StartUp
    {
        public static void Main()
        {
            ClassB y = new ClassB();
            ClassB x = new ClassB();
            ClassA z = new ClassC();

            y.AAA(); y.BBB(); y.CCC();
            x.AAA(); x.BBB(); x.CCC();
            z.AAA(); z.BBB(); z.CCC();
        }
    }
}
