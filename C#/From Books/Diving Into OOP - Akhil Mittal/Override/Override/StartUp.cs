using System;

namespace Override
{
    public class StartUp
    {
        public static void Main()
        {
            ClassB y = new ClassB();
            ClassA x = new ClassA();
            ClassB z = new ClassB();

            y.AAA();y.BBB();y.CCC();
            x.AAA();x.BBB();x.CCC();
            z.AAA();z.BBB();z.CCC();
        }
    }
}
