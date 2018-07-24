using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExample
{
    class Triangle : Shape
    {
        public void GetTrig()
        {
            Console.WriteLine("Enter base and height : ");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return (float)1 / 2 * x * y;
        }
    }
}
