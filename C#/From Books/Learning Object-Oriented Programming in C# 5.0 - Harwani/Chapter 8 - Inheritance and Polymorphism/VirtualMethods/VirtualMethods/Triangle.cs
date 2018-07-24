using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethods
{
    public class Triangle : Rect
    {
        public void GetValue()
        {
            Console.WriteLine("Enter base and height: ");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return (float)1 / 2 * x * y;
        }
    }
}
