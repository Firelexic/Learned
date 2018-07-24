using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPropeties
{
    class Rect : Shape
    {
        public override float length
        {
            get { return l; }
            set { l = value; }
        }

        public override float breadth
        {
            get { return b; }
            set { b = value; }
        }

        public float Area()
        {
            return l * b;
        }
    }
}
