using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexample
{
    public static class ShapeMath
    {
        public static double GetArea(
            string shape = "",
            double length = 0,
            double lengthTwo = 0)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * lengthTwo;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * (lengthTwo / 2);
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(length, 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
