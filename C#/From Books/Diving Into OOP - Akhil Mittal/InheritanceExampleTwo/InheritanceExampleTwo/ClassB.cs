using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExampleTwo
{
    public class ClassB
    {
        public int x = 100;

        public void DisplayOne()
        {
            Console.WriteLine("ClassB DisplayOne");
        }

        public void DisplayTwo()
        {
            Console.WriteLine("ClassB DisplayTwo");
        }

        public void Bark()
        {
            Console.WriteLine("Bark ! ");
        }
    }
}
