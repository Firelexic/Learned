using System;
using System.Collections.Generic;
using System.Text;

namespace Override
{
    public class ClassA : ClassB
    {
        public override void AAA()
        {
            Console.WriteLine("ClassA AAA");
        }

        public override void BBB()
        {
            Console.WriteLine("ClassA BBB");
        }

        public override void CCC()
        {
            Console.WriteLine("ClassA CCC");
        }

    }
}
