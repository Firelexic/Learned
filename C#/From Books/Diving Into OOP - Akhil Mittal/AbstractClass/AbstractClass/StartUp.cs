using System;

namespace AbstractClass
{
    public class StartUp
    {
        public static void Main()
        {
            ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();classB.XXX();
            
        }
    }
}
