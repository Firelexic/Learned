using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexample
{
    public class ClassC : ClassA
    {
        public override void AAA()
        {
            Console.WriteLine("ClassC AAA");
        }

        public void CCC()
        {
            Console.WriteLine("ClassC CCC");
        }
    }
}
