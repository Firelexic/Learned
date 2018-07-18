using System;
using System.Collections.Generic;
using System.Text;

namespace OOPInheritance
{
    public class Triangle : Polygon
    {
        public int Area()
        {
            return ((width * height) / 2);
        }
    }
}
