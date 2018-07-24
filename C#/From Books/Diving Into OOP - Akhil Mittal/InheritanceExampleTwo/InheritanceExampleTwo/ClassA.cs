using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExampleTwo
{
    public class ClassA : ClassB
    {
        public void DisplayOne()
        {
            Console.WriteLine("ClassA DisplayOne");
            base.DisplayTwo();
            
        }

        public void Burk()
        {
            base.Bark();
        }
    }
}
