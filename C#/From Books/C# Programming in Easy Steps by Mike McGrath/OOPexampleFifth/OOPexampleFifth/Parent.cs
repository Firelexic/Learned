using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexampleFifth
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent");
        }
        public Parent(int num)
        {
            Console.WriteLine("Parent + Called : " + num);
        }
    }
}
