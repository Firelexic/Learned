using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExampleOne
{
    public class ClassA : ClassB
    {
        public void DisplayOne()
        {
            Console.WriteLine("ClassA DisplayOne");
            base.DisplayOne();
        }
    }
}
