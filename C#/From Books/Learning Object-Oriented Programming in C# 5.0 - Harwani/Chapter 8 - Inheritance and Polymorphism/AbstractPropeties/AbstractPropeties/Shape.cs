using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPropeties
{
    abstract class Shape
    {
        protected float l, b;

        public abstract float length
        {
            get;
            set;
        }

        public abstract float breadth
        {
            get;
            set;
        }
    }
}
