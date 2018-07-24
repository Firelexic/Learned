using System;

namespace InheritanceAndPolymorphism
{
    public class StartUp
    {
        public static void Main()
        {
            ClassA x = new ClassA();
            ClassB y = new ClassB();
            ClassB z = new ClassB();
            x.AAA();x.BBB();x.CCC();
            y.AAA();y.BBB();y.CCC();
            z.AAA();z.BBB();z.CCC();
        }
    }
}
