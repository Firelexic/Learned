using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorExampleTwo
{
    public class ParameterizedCon
    {
        int x;
        public ParameterizedCon(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called : " + i);
        }
       
        public void Display()
        {
            Console.WriteLine("Value of x is : " + x);
        }
    }
}
