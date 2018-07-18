using System;
using System.Collections.Generic;
using System.Text;

namespace OOPInheritance
{
    public class Rectangle : Polygon
    {
        public int Area()
        {
            return (width * height);
        }
    }
}
