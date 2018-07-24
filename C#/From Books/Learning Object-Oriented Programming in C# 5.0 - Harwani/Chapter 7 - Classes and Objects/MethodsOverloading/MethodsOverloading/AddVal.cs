using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsOverloading
{
    public class AddVal
    {
        public void ComputeSum(int x)
        {
            Console.WriteLine("Sum is {0}",x);
        }

        public void ComputeSum(int x,int y)
        {
            Console.WriteLine("Sum is {0}",x + y);
        }

        public void ComputeSum(int x,double y)
        {
            Console.WriteLine("Sum is {0}",x + y);
        }
        public void ComputeSum(double x, double y)
        {
            Console.WriteLine("Sum is {0}" ,x + y);
        }
    }
}
