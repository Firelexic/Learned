using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPropeties
{
    class Triangle : Shape
    { 
        public override float length
        {
            get { return l; }
            set { length = value; }
        }

        public override float breadth
        {
            get { return b; }
            set { b = value; }
        }

        public float Area()
        {
            return (float)1 / 2 * l * b;
        }
    }
}
