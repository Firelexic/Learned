using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexample
{
    public class ClassA : ClassB
    {
        public virtual void AAA()
        {
            Console.WriteLine("ClassA AAA");
        }

        public new void BBB()
        {
            Console.WriteLine("ClassA BBB");
        }

        public override void CCC()
        {
            Console.WriteLine("ClassA CCC");
        }
    }
}
