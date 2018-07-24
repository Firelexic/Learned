using System;
using System.Collections.Generic;
using System.Text;

namespace Override
{
    public class ClassB
    {
        public virtual void AAA()
        {
            Console.WriteLine("ClassB AAA");
        }
        
        public virtual void BBB()
        {
            Console.WriteLine("ClassB BBB");
        }

        public virtual void CCC()
        {
            Console.WriteLine("ClassB CCC");
        }
    }
}
